using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
	public static class CoreWrapper
	{
		const string dllName = "CoreVisualNes.dll";

		[DllImport(dllName)] public extern static void initEmulator();
		[DllImport(dllName)] public extern static void release();

		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool startLogging([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string filename, [MarshalAs(UnmanagedType.I1)]bool logAsHex, [MarshalAs(UnmanagedType.I1)]bool logAsCsv);
		[DllImport(dllName)] public extern static void stopLogging();

		[DllImport(dllName)] public extern static void setMirroringType(MirroringType mirroring);

		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool isNodeHigh(int nodeNumber);
		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool isTransistorOn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string transistorName);

		[DllImport(dllName)] public extern static void getState(ref EmulationState state);

		[DllImport(dllName)] public extern static void setTrace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string tracedColumns);

		[DllImport(dllName)] public extern static void step(UInt32 halfCycleCount);
		[DllImport(dllName)] public extern static void reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string resetState, [MarshalAs(UnmanagedType.I1)]bool softReset);

		[DllImport(dllName, EntryPoint = "getMemoryState")] private static extern int getMemoryStateWrapper(MemoryType type, IntPtr buffer);
		public static byte[] getMemoryState(MemoryType type)
		{
			byte[] buffer = new byte[0xFFFF];
			GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			try {
				int memorySize = getMemoryStateWrapper(type, handle.AddrOfPinnedObject());
				Array.Resize(ref buffer, (int)memorySize);
			} finally {
				handle.Free();
			}
			return buffer;
		}

		[DllImport(dllName, EntryPoint = "setMemoryState")] private static extern void setMemoryStateWrapper(MemoryType type, IntPtr buffer, Int32 length);
		public static void setMemoryState(MemoryType type, byte[] data)
		{
			GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				setMemoryStateWrapper(type, handle.AddrOfPinnedObject(), data.Length);
			} finally {
				handle.Free();
			}
		}

		[DllImport(dllName, EntryPoint = "getFrameBuffer")] private static extern void getFrameBufferWrapper(IntPtr buffer);
		public static byte[] getFrameBuffer()
		{
			byte[] buffer = new byte[256*240*4];
			GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			try {
				getFrameBufferWrapper(handle.AddrOfPinnedObject());
			} finally {
				handle.Free();
			}
			return buffer;
		}
	}

	public enum MirroringType
	{
		Horizontal,
		Vertical,
		ScreenAOnly,
		ScreenBOnly,
		FourScreens
	}

	public struct EmulationState
	{
		public int halfcycle;
		public int hpos;
		public int vpos;
		public int vramaddr_v;
		public int vramAddr_t;
		public int vbl_flag;
		public int spr_overflow;
		public int spr0_hit;
		public int clk;
		public int ab;
		public int d;

		public int a;
		public int x;
		public int y;
		public int ps;
		public int sp;
		public int pc;
		public int opCode;
		public int fetch;

		public int cpu_ab;
		public int cpu_db;

		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10000, ArraySubType = UnmanagedType.I4)]
		public int[] recentLog;
	};

	public enum MemoryType
	{
		CpuRam = 0, //$0000-$07FF (mirrored to $1FFF)
		PrgRam = 1, //$8000-$FFFF
		ChrRam = 2, //$0000-$1FFF
		NametableRam = 3, //$2000-$2FFF ($2000-$23FF is nametable A, $2400-$27FF is nametable B)
		PaletteRam = 4, //internal to the PPU - 32 bytes (including some mirrors)
		SpriteRam = 5,  //interal to the PPU.  256 bytes for primary + 32 bytes for secondary
		FullState = 6, //all of the above put together + a state of all of the nodes in the simulation (used for save/load state)
	}

}
