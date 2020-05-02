using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
	class transistor
	{
		public string name;
		public bool on;
		public int gate;
		public int c1;
		public int c2;
		public List<int> bb;
	}

	class node
	{
		public List<List<int>> segs = new List<List<int>>();
		public int num = -1;
		public bool pullup = false;
		public bool pulldown = false;
		public bool state = false;
		public List<transistor> gates = new List<transistor>();
		public List<transistor> c1c2s = new List<transistor>();
		public int area = 0;
		public bool floating = true;
	}

	class transdef
	{
		public string name;
		public int gate;
		public int c1;
		public int c2;
		public List<int> bb;
		//public List<int> unused;
		//public bool unused2;
	}

	public class ChipDefinitions
	{
		List<node> _nodes = new List<node>();
		List<transistor> _transistors = new List<transistor>();
		Dictionary<string, int> _nodeNumberByName = new Dictionary<string, int>();
		Dictionary<int, string> _nodeNameByNumber = new Dictionary<int, string>();
		Dictionary<string, int> _transistorIndexes = new Dictionary<string, int>();
		List<List<int>> _segmentDefs = new List<List<int>>();
		List<transdef> _transDefs = new List<transdef>();
		int ngnd;
		int npwr;

		internal List<List<int>> SegmentDefs { get { return _segmentDefs; } }
		internal List<node> Nodes { get { return _nodes; } }
		internal List<transistor> Transistors { get { return _transistors; } }
		internal Dictionary<string, int> NodeNumberByName { get { return _nodeNumberByName; } }

		const int cpuOffset = 13000;
		const int cpuXOffset = 0;
		const int cpuYOffset = 0;
		const int ppuXOffset = 1500;
		const int ppuYOffset = 12500;

		Dictionary<int, int> idConvertTable = new Dictionary<int, int>() {
			{ 10000 + cpuOffset, 1 }, //vcc
			{ 10001 + cpuOffset, 2 }, //vss
			{ 10004 + cpuOffset, 1934 }, //reset

			{ 11669 + cpuOffset, 772 }, //cpu_clk_in -> clk0

			{ 1013, 11819 + cpuOffset }, //io_db0 -> cpu_db0
			{ 765, 11966 + cpuOffset }, //db1
			{ 431, 12056 + cpuOffset }, //db2
			{ 87, 12091 + cpuOffset }, //db3
			{ 11, 12090 + cpuOffset }, //db4
			{ 10, 12089 + cpuOffset }, //db5
			{ 9, 12088 + cpuOffset }, //db6
			{ 8, 12087 + cpuOffset }, //db7

			{ 12, 10020 + cpuOffset }, //io_ab0 -> cpu_ab0
			{ 6, 10019 + cpuOffset }, //io_ab1 -> cpu_ab1
			{ 7, 10030 + cpuOffset }, //io_ab2 -> cpu_ab2

			{ 10331 + cpuOffset, 1031 }, //nmi -> int
			{ 10092 + cpuOffset, 1224 }, //cpu_rw -> io_rw
		};

		public ChipDefinitions()
		{
			loadSegmentDefinitions();
			loadTransistorDefinitions();
			loadNodeNames();

			ngnd = _nodeNumberByName["vss"];
			npwr = _nodeNumberByName["vcc"];

			setupNodes();
			setupTransistors();
		}

		public string getNodeName(int nn)
		{
			string name;
			_nodeNameByNumber.TryGetValue(nn, out name);
			return name ?? "";
		}

		public int getTransistorIndex(string transName)
		{
			int index = 0;
			_transistorIndexes.TryGetValue(transName, out index);
			return index;
		}

		public HashSet<int> getNodeGroup(int nn)
		{
			HashSet<int> group = new HashSet<int>();
			addNodeToGroup(nn, group);
			return group;
		}

		void addNodeToGroup(int nn, HashSet<int> group)
		{
			if(nn == ngnd) {
				return;
			}
			if(nn == npwr) {
				return;
			}
			if(group.Add(nn)) {
				foreach(transistor t in _nodes[nn].c1c2s) {
					if(CoreWrapper.isTransistorOn(t.name)) {
						addNodeToGroup(t.c1 == nn ? t.c2 : t.c1, group);
					}
				}
			}
		}

		int convertId(int id)
		{
			if(idConvertTable.ContainsKey(id)) {
				return idConvertTable[id];
			}
			return id;
		}

		void loadSegmentDefinitions()
		{
			Action<string, int, int, int> loadDefs = (filename, idOffset, xOffset, yOffset) => {
				foreach(string line in File.ReadAllLines(filename)) {
					List<int> segmentDef = new List<int>();
					string[] values = line.Split(',');
					for(int i = 0; i < values.Length; i++) {
						if(i == 0) {
							segmentDef.Add(convertId(int.Parse(values[i]) + idOffset));
						} else if(i > 2) {
							segmentDef.Add(int.Parse(values[i]) + (i % 2 == 0 ? yOffset : xOffset));
						} else {
							segmentDef.Add(int.Parse(values[i]));
						}
					}
					_segmentDefs.Add(segmentDef);
				}
			};

			loadDefs("segdefs.txt", 0, ppuXOffset, ppuYOffset);
			loadDefs("cpusegdefs.txt", cpuOffset, cpuXOffset, cpuYOffset);
		}

		void loadTransistorDefinitions()
		{
			Action<string, string, int, int, int> loadDefs = (filename, namePrefix, idOffset, xOffset, yOffset) => {
				foreach(string line in File.ReadAllLines(filename)) {
					if(line.StartsWith("#")) {
						continue;
					}
					string[] values = line.Split(',');
					string[] bbValues = values[4].Split('|');
					List<int> bb = new List<int>();
					for(int i = 0; i < 4; i++) {
						bb.Add(int.Parse(bbValues[i]) + (i < 2 ? xOffset : yOffset));
					}

					_transDefs.Add(new transdef() {
						name = namePrefix + values[0],
						gate = convertId(int.Parse(values[1]) + idOffset),
						c1 = convertId(int.Parse(values[2]) + idOffset),
						c2 = convertId(int.Parse(values[3]) + idOffset),
						bb = bb
					});
				}
			};

			loadDefs("transdefs.txt", "", 0, ppuXOffset, ppuYOffset);
			loadDefs("cputransdefs_revised.txt", "cpu_", cpuOffset, cpuXOffset, cpuYOffset);
		}

		void loadNodeNames()
		{
			Action<string, string, int> loadDefs = (filename, namePrefix, idOffset) => {
				foreach(string line in File.ReadAllLines(filename)) {
					string[] values = line.Split(',');
					_nodeNumberByName[namePrefix + values[0]] = int.Parse(values[1]) + idOffset;
					_nodeNameByNumber[int.Parse(values[1]) + idOffset] = namePrefix + values[0];
				}
			};

			loadDefs("nodenames.txt", "", 0);
			loadDefs("cpunodenames.txt", "cpu_", cpuOffset);
		}

		void setupNodes()
		{
			int maxID = 0;
			for(int i = 0, len = _segmentDefs.Count; i < len; i++) {
				maxID = Math.Max(maxID, _segmentDefs[i][0]);
			}
			for(int i = 0; i <= maxID; i++) {
				_nodes.Add(null);
			}

			for(int i = 0, len = _segmentDefs.Count; i < len; i++) {
				List<int> segmentDef = _segmentDefs[i];
				int w = segmentDef[0];

				if(_nodes[w] == null) {
					_nodes[w] = new node();
					_nodes[w].num = w;
					_nodes[w].pullup = segmentDef[1] == 1;
					_nodes[w].state = false;
					_nodes[w].area = 0;
					_nodes[w].segs = new List<List<int>>();
				}

				if(w == ngnd)
					continue;
				if(w == npwr)
					continue;

				int area = segmentDef[segmentDef.Count - 2] * segmentDef[4] - segmentDef[3] * segmentDef[segmentDef.Count - 1];
				for(int j = 3; j + 4 < segmentDef.Count; j += 2) {
					area += segmentDef[j] * segmentDef[j + 3] - segmentDef[j + 2] * segmentDef[j - 1];
				}
				if(area < 0) {
					area = -area;
				}
				_nodes[w].area += area;
				_nodes[w].segs.Add(segmentDef.GetRange(3, segmentDef.Count - 3));
			}
		}

		void setupTransistors()
		{
			int i = 0;
			foreach(transdef tdef in _transDefs) {
				string name = tdef.name;
				int gate = tdef.gate;
				int c1 = tdef.c1;
				int c2 = tdef.c2;

				if(c1 == ngnd) { c1 = c2; c2 = ngnd; }
				if(c1 == npwr) { c1 = c2; c2 = npwr; }

				transistor trans = new transistor { name = name, on = false, gate = gate, c1 = c1, c2 = c2, bb = tdef.bb };
				_nodes[gate].gates.Add(trans);
				_nodes[c1].c1c2s.Add(trans);
				_nodes[c2].c1c2s.Add(trans);
				_transistorIndexes[name] = i;
				_transistors.Add(trans);
				i++;
			}
		}
	}
}
