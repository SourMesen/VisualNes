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
		const string dllName = "Core2C02.dll";

		[DllImport(dllName)] public extern static void initEmulator();
		[DllImport(dllName)] public extern static void release();

		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool startLogging([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string filename, [MarshalAs(UnmanagedType.I1)]bool logAsHex, [MarshalAs(UnmanagedType.I1)]bool logAsCsv);
		[DllImport(dllName)] public extern static void stopLogging();

		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool isNodeHigh(int nodeNumber);
		[DllImport(dllName)] [return: MarshalAs(UnmanagedType.I1)] public extern static bool isTransistorOn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string transistorName);

		[DllImport(dllName)] public extern static void getState(ref EmulationState state);

		[DllImport(dllName)] public extern static void setTrace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string tracedColumns);

		[DllImport(dllName)] public extern static void step(UInt32 halfCycleCount);
		[DllImport(dllName)] public extern static void reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]string resetState);

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

		[DllImport(dllName, EntryPoint = "setProgram")] private static extern void setProgramWrapper(IntPtr buffer, UInt32 length);
		public static void setProgram(byte[] data)
		{
			GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				setProgramWrapper(handle.AddrOfPinnedObject(), (UInt32)data.Length);
			} finally {
				handle.Free();
			}
		}
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

		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10000, ArraySubType = UnmanagedType.I4)]
		public int[] recentLog;
	};

	public enum MemoryType
	{
		Vram = 0,
		PaletteRam = 1,
		SpriteRam = 2,
		FullState = 3,
	}

}
