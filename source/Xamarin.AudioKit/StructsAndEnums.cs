using System;
using System.Runtime.InteropServices;

using AudioToolbox;
using AudioUnit;
using ObjCRuntime;

namespace Xamarin.EZAudio
{
	[StructLayout (LayoutKind.Sequential)]
	public struct SplitComplex
	{
		IntPtr realp;
		IntPtr imagp;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct AudioBufferList
	{
		public uint mNumberBuffers;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst = 1)]
		public AudioBuffer[] mBuffer;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct AudioPlotGlPoint
	{
		public float x;
		public float y;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct PlotHistoryInfo
	{
		public unsafe float* buffer;
		public int bufferSize;
		public CircularBuffer circularBuffer;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct AudioNodeInfo
	{
		public AudioUnit.AudioUnit audioUnit;
		public int node;
	}

	[Native]
	public enum PlotType : long
	{
		Buffer,
		Rolling
	}

	[Native]
	public enum RecorderFileType : long
	{
		Aiff,
		M4a,
		Wav
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CircularBuffer
	{
		public IntPtr buffer;
		public int length;
		public int tail;
		public int head;
		public int fillCount;
	}
}