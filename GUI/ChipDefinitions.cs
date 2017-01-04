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

		void loadSegmentDefinitions()
		{
			foreach(string line in File.ReadAllLines("segdefs.txt")) {
				List<int> segmentDef = new List<int>();
				foreach(string value in line.Split(',')) {
					segmentDef.Add(int.Parse(value));
				}
				_segmentDefs.Add(segmentDef);
			}
		}

		void loadTransistorDefinitions()
		{
			foreach(string line in File.ReadAllLines("transdefs.txt")) {
				string[] values = line.Split(',');
				string[] bbValues = values[4].Split('|');
				List<int> bb = new List<int>();
				foreach(string value in bbValues) {
					bb.Add(int.Parse(value));
				}

				_transDefs.Add(new transdef() {
					name = values[0],
					gate = int.Parse(values[1]),
					c1 = int.Parse(values[2]),
					c2 = int.Parse(values[3]),
					bb = bb
				});
			}
		}

		void loadNodeNames()
		{
			foreach(string line in File.ReadAllLines("nodenames.txt")) {
				string[] values = line.Split(',');
				_nodeNumberByName[values[0]] = int.Parse(values[1]);
				_nodeNameByNumber[int.Parse(values[1])] = values[0];
			}
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
