using System;
using System.Runtime.InteropServices;
using Foundation;
using CoreGraphics;
using ObjCRuntime;
using GLKit;
using AudioUnit;
using UIKit;
using AudioToolbox;

namespace Xamarin.AudioKit
{
	static class IntPtrHelper
	{
		[DllImport (Constants.libSystemLibrary, EntryPoint = "memcpy")]
		extern internal static void MemoryCopy (IntPtr destination, IntPtr source, nuint size);

		public static void ConvertToIntPtr<T> (T[] array, out IntPtr pArray) where T : struct
		{
			var sizeType = Marshal.SizeOf (typeof(T));
			var sizeArray = array.Length;
			pArray = Marshal.AllocHGlobal (sizeArray * sizeType);
			for (int i = 0; i < sizeArray; i++)
				Marshal.StructureToPtr (array [i], IntPtr.Add (pArray, i * sizeType), false);
		}

		public static void ConvertToIntPtr<T> (T structure, out IntPtr pData) where T : struct
		{
			var sizeType = Marshal.SizeOf (typeof(T));
			pData = Marshal.AllocHGlobal (sizeType);
			Marshal.StructureToPtr (structure, pData, false);
		}
	}

	public partial class ConvolutionAudioUnit : AUAudioUnit
	{
		public void SetupAudioFileTable (float[] data)
		{
			if (data.Length == 0) {
				_SetupAudioFileTable (IntPtr.Zero, 0);
				return;
			}

			IntPtr pData;
			IntPtrHelper.ConvertToIntPtr<float> (data, out pData);
			_SetupAudioFileTable (pData, (uint)data.Length);
			Marshal.FreeHGlobal (pData);
		}
	}

	public partial class OperationEffectAudioUnit : AUAudioUnit
	{
		public void SetParameters (double[] parameters)
		{
			if (parameters == null) {
				_SetParameters (null);
				return;
			}

			var nsParameters = new NSNumber[parameters.Length];

			for (int i = 0; i < parameters.Length; i++)
				nsParameters [i] = new NSNumber (parameters [i]);

			_SetParameters (nsParameters);
		}
	}

	public partial class OperationGeneratorAudioUnit : AUAudioUnit
	{
		public void Trigger (double[] parameters)
		{
			if (parameters == null) {
				_SetParameters (null);
				return;
			}

			var nsParameters = new NSNumber[parameters.Length];

			for (int i = 0; i < parameters.Length; i++)
				nsParameters [i] = new NSNumber (parameters [i]);

			_Trigger (nsParameters);
		}

		public void SetParameters (double[] parameters)
		{
			if (parameters == null) {
				_SetParameters (null);
				return;
			}

			var nsParameters = new NSNumber[parameters.Length];

			for (int i = 0; i < parameters.Length; i++)
				nsParameters [i] = new NSNumber (parameters [i]);

			_SetParameters (nsParameters);
		}
	}

	public partial class PhaseLockedVocoderAudioUnit : AUAudioUnit
	{
		public void SetupAudioFileTable (float[] data)
		{
			if (data.Length == 0) {
				_SetupAudioFileTable (IntPtr.Zero, 0);
				return;
			}

			IntPtr pData;
			IntPtrHelper.ConvertToIntPtr<float> (data, out pData);
			_SetupAudioFileTable (pData, (uint)data.Length);
			Marshal.FreeHGlobal (pData);
		}
	}

	public partial class Fft : NSObject
	{
		public unsafe void FftComputation (EZAudio.AudioFft fft, float[] fftData)
		{
			var sizeType = Marshal.SizeOf (typeof(float));
			IntPtr pFftData;
			IntPtrHelper.ConvertToIntPtr<float> (fftData, out pFftData);
			_FftComputation (fft, pFftData, (nuint)fftData.Length);

			fixed (float* pArray = &fftData[0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)pArray, pFftData, (nuint)(fftData.Length * sizeType));
			}

			Marshal.FreeHGlobal (pFftData);
		}
	}

	public partial class NodeFftPlot : EZAudio.AudioPlot
	{
		public unsafe void FftComputation (EZAudio.AudioFft fft, float[] fftData)
		{
			var sizeType = Marshal.SizeOf (typeof(float));
			IntPtr pFftData;
			IntPtrHelper.ConvertToIntPtr<float> (fftData, out pFftData);
			_FftComputation (fft, pFftData, (nuint)fftData.Length);

			fixed (float* pArray = &fftData[0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)pArray, pFftData, (nuint)(fftData.Length * sizeType));
			}

			Marshal.FreeHGlobal (pFftData);
		}
	}
}

namespace Xamarin.EZAudio
{
	static class IntPtrHelper
	{
		[DllImport (Constants.libSystemLibrary, EntryPoint = "memcpy")]
		extern internal static void MemoryCopy (IntPtr destination, IntPtr source, nuint size);

		public static void ConvertToIntPtr<T> (T structure, out IntPtr pData) where T : struct
		{
			var sizeType = Marshal.SizeOf (typeof(T));
			pData = Marshal.AllocHGlobal (sizeType);
			Marshal.StructureToPtr (structure, pData, false);
		}

		public static void ConvertToIntPtr<T> (T[] array, out IntPtr pArray) where T : struct
		{
			var sizeType = Marshal.SizeOf (typeof(T));
			var sizeArray = array.Length;
			pArray = Marshal.AllocHGlobal (sizeArray * sizeType);

			for (int i = 0; i < sizeArray; i++)
				Marshal.StructureToPtr (array [i], IntPtr.Add (pArray, i * sizeType), false);
		}

		public static void ConvertToIntPtr<T> (T[][] arrays, out IntPtr pDataArrays, out IntPtr pArrays) where T : struct
		{
			var sizeType = Marshal.SizeOf (typeof(T));
			var totalOfArrays = arrays.Length;
			var sizeArray = arrays [0].Length;
			pDataArrays = Marshal.AllocHGlobal (sizeType * totalOfArrays * sizeArray);
			pArrays = Marshal.AllocHGlobal (IntPtr.Size * totalOfArrays);

			for (int i = 0; i < totalOfArrays; i++) {

				var offset = i * sizeArray;

				for (int j = 0; j < sizeArray; j++)
					Marshal.StructureToPtr (arrays [i] [j], IntPtr.Add (pDataArrays, offset + (j * sizeType)), false);

				Marshal.WriteIntPtr (pArrays, IntPtr.Size * i, IntPtr.Add (pDataArrays, offset));
			}
		}
	}

	public partial class AudioFft : NSObject
	{

		// -(float *)computeFFTWithBuffer:(float *)buffer withBufferSize:(UInt32)bufferSize;
		public unsafe float[] ComputeFft (float[] buffer)
		{
			if (buffer == null || buffer.Length == 0)
				return null;

			IntPtr pBuffer;
			IntPtrHelper.ConvertToIntPtr<float> (buffer, out pBuffer);
			IntPtr pResult = _ComputeFft (pBuffer, (uint)buffer.Length);
			Marshal.FreeHGlobal (pBuffer);

			var resultSize = buffer.Length / 2;
			var sizeType = Marshal.SizeOf (typeof(float));
			var result = new float[resultSize];

			fixed (float* pArray = &result[0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)pArray, pResult, (nuint)(resultSize * sizeType));
			}

			return result;
		}
	}

	public partial class AudioFftRolling : AudioFft
	{
		public float [] TimeDomainData {
			get {
				var sizeType = Marshal.SizeOf (typeof(float));
				var pBuffer = _TimeDomainData;
				var bufferLength = _TimeDomainBufferSize;
				var buffer = new float [bufferLength];

				fixed (float* pArray = &buffer[0]) {
					IntPtrHelper.MemoryCopy ((IntPtr)pArray, pBuffer, (nuint)(bufferLength * sizeType));
				}

				return buffer;
			}
		}
	}

	public partial class AudioFile : NSObject
	{
		public unsafe void ReadFrames (uint frames, AudioBuffers audioBufferList, out uint bufferSize, out bool eof)
		{
			_ReadFrames (frames, (IntPtr)audioBufferList, out bufferSize, out eof);
		}
	}

	public partial class AudioFloatConverter
	{
		static uint? defaultPacketSize;

		public static uint DefaultPacketSize {
			get {
				if (defaultPacketSize != null)
					return defaultPacketSize.Value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "EZAudioFloatConverterDefaultPacketSize");
				defaultPacketSize = (uint)Marshal.PtrToStructure (ptr, typeof(uint));
				Dlfcn.dlclose (RTLD_MAIN_ONLY);

				return defaultPacketSize.Value;
			}
		}

		public unsafe void ConvertData (AudioBuffers audioBufferList, uint frames, float[][] buffers)
		{
			var totalArrays = buffers.Length;
			var arraySize = buffers [0].Length;
			var pSize = Marshal.SizeOf (typeof(IntPtr));
			IntPtr pDataBuffers;
			IntPtr pPointerBuffers;
			IntPtrHelper.ConvertToIntPtr<float> (buffers, out pDataBuffers, out pPointerBuffers);

			_ConvertData ((IntPtr)audioBufferList, frames, pPointerBuffers);

			for (int i = 0; i < totalArrays; i++) {
				
				var pArray = Marshal.ReadIntPtr (IntPtr.Add (pPointerBuffers, i * pSize));

				fixed (float *arrAddr = &buffers[i][0]) {
					IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pArray, (nuint)arraySize);
				}
			}

			Marshal.FreeHGlobal (pDataBuffers);
			Marshal.FreeHGlobal (pPointerBuffers);
		}

		public unsafe void ConvertData (AudioBuffers audioBufferList, uint frames, float[][] buffers, out AudioStreamPacketDescription packetDescriptions)
		{
			var totalArrays = buffers.Length;
			var arraySize = buffers [0].Length;
			var pSize = Marshal.SizeOf (typeof(IntPtr));
			IntPtr pDataBuffers;
			IntPtr pPointerBuffers;
			IntPtrHelper.ConvertToIntPtr<float> (buffers, out pDataBuffers, out pPointerBuffers);

			_ConvertData ((IntPtr)audioBufferList, frames, pPointerBuffers, out packetDescriptions);

			for (int i = 0; i < totalArrays; i++) {

				var pArray = Marshal.ReadIntPtr (IntPtr.Add (pPointerBuffers, i * pSize));

				fixed (float *arrAddr = &buffers[i][0]) {
					IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pArray, (nuint)arraySize);
				}
			}

			Marshal.FreeHGlobal (pDataBuffers);
			Marshal.FreeHGlobal (pPointerBuffers);
		}
	}

	public partial class AudioFloatData : NSObject
	{
		public unsafe static AudioFloatData GetInstance (float[][] buffers)
		{
			var channels = buffers.Length;
			var bufferSize = buffers [0].Length;
			IntPtr pDataBuffers;
			IntPtr pPointerBuffers;
			IntPtrHelper.ConvertToIntPtr<float> (buffers, out pDataBuffers, out pPointerBuffers);

			var instance = _GetInstance (channels, pPointerBuffers, (uint)bufferSize);

			Marshal.FreeHGlobal (pDataBuffers);
			Marshal.FreeHGlobal (pPointerBuffers);

			return instance;
		}

		public float[][] Buffers {
			get;
			private set;
		}

		public float[] BufferForChannel (int channel)
		{
			return channel < NumberOfChannels ? Buffers [channel] : null;
		}
	}

	public partial class AudioPlot : Plot
	{
		static uint? defaultHistoryBufferLength;

		public static uint DefaultHistoryBufferLength {
			get {
				if (defaultHistoryBufferLength != null)
					return defaultHistoryBufferLength.Value;

				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "EZAudioPlotDefaultHistoryBufferLength");
				defaultHistoryBufferLength = (uint)Marshal.PtrToStructure (ptr, typeof(uint));
				Dlfcn.dlclose (RTLD_MAIN_ONLY);

				return defaultHistoryBufferLength.Value;
			}
		}

		// extern const UInt32 EZAudioPlotDefaultMaxHistoryBufferLength;
		[Field ("EZAudioPlotDefaultMaxHistoryBufferLength", "__Internal")]
		static uint? defaultMaxHistoryBufferLength;

		public static uint DefaultMaxHistoryBufferLength { 
			get {
				if (defaultMaxHistoryBufferLength != null)
					return defaultMaxHistoryBufferLength.Value;

				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "EZAudioPlotDefaultMaxHistoryBufferLength");
				defaultMaxHistoryBufferLength = (uint)Marshal.PtrToStructure (ptr, typeof(uint));
				Dlfcn.dlclose (RTLD_MAIN_ONLY);

				return defaultMaxHistoryBufferLength.Value;
			}
		}

		public CGPath CreatePath (CGPoint[] points, CGRect rect)
		{
			IntPtr pPoints;
			IntPtrHelper.ConvertToIntPtr<CGPoint> (points, out pPoints);
			var path = _CreatePath (pPoints, (uint)points.Length, rect);
			Marshal.FreeHGlobal (pPoints);

			return path;
		}

		public unsafe void SetSampleData (float[] data)
		{
			if (data.Length == 0) {
				_SetSampleData (IntPtr.Zero, 0);
				return;
			}

			IntPtr pData;
			IntPtrHelper.ConvertToIntPtr<float> (data, out pData);
			_SetSampleData (pData, data.Length);
			Marshal.FreeHGlobal (pData);
		}

		public CGPoint[] Points {
			get {
				if (_PointCount == 0)
					return null;

				var points = new CGPoint[_PointCount];
				var sizeType = Marshal.SizeOf (typeof(CGPoint));

				unsafe {
					fixed (CGPoint* pPoints = &points[0]) {
						IntPtrHelper.MemoryCopy ((IntPtr)pPoints, _Points, (nuint)(sizeType * _PointCount));
					}
				}

				return points;
			}
			set {
				if (value.Length == 0) {
					_Points = IntPtr.Zero;
					_PointCount = 0;
					return;
				}

				IntPtr pPoints;
				IntPtrHelper.ConvertToIntPtr<CGPoint> (value, out pPoints);
				_Points = pPoints;
				_PointCount = (uint)value.Length;
				Marshal.FreeHGlobal (pPoints);
			}
		}
	}

	public partial class AudioPlotGl : GLKView
	{
		public unsafe void UpdateBuffer (float[] buffer)
		{
			IntPtr pBuffer;
			IntPtrHelper.ConvertToIntPtr<float> (buffer, out pBuffer);
			_UpdateBuffer (pBuffer, (uint)buffer.Length);
			Marshal.FreeHGlobal (pBuffer);
		}

		public unsafe void Redraw (AudioPlotGlPoint[] points, GLKBaseEffect baseEffect, uint vbo, uint vab, bool interpolated, bool mirrored, float gain)
		{
			IntPtr pPoints;
			IntPtrHelper.ConvertToIntPtr<AudioPlotGlPoint> (points, out pPoints);
			_Redraw (pPoints, (uint)points.Length, baseEffect, vbo, vab, interpolated, mirrored, gain);
			Marshal.FreeHGlobal (pPoints);
		}

		public unsafe void SetSampleData (float[] data)
		{
			if (data.Length == 0) {
				_SetSampleData (IntPtr.Zero, 0);
				return;
			}

			IntPtr pData;
			IntPtrHelper.ConvertToIntPtr<float> (data, out pData);
			_SetSampleData (pData, data.Length);
			Marshal.FreeHGlobal (pData);
		}
	}

	public partial class AudioUtilities : NSObject
	{
		public void GetAudioBufferList (out AudioBuffers audioBufferList, uint frames, uint channels, bool interleaved)
		{
			var pAudioBufferList = _GetAudioBufferList (frames, channels, interleaved);
			audioBufferList = new AudioBuffers (pAudioBufferList, true);
		}

		public unsafe float[][] GetFloatBuffers (uint frames, uint channels)
		{
			var pSize = Marshal.SizeOf (typeof(IntPtr));
			var sizeType = Marshal.SizeOf (typeof(float));
			var arraySize = sizeType * frames;

			var arrays = new float [channels][];
			var pArrays = _GetFloatBuffers (frames, channels);

			for (int i = 0; i < channels; i++) {
				arrays [i] = new float[frames];
				var pArray = Marshal.ReadIntPtr (IntPtr.Add (pArrays, i * pSize));

				fixed (float *arrAddr = &arrays[i][0]) {
					IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pArray, (nuint)arraySize);
				}
			}

			return arrays;
		}

		public unsafe void FreeBufferList (AudioBuffers bufferList)
		{
			_FreeBufferList ((IntPtr)bufferList);
		}

		public void FreeFloatBuffers (float[][] buffers)
		{
			for (int i = 0; i < buffers.Length; i++)
				buffers [i] = null;
		}

		public unsafe void AppendBufferAndShift (float[] buffer, float[] scrollHistory)
		{
			var sizeType = Marshal.SizeOf (typeof(float));
			IntPtr pBuffer;
			IntPtrHelper.ConvertToIntPtr<float> (buffer, out pBuffer);

			IntPtr pScrollHistory;
			IntPtrHelper.ConvertToIntPtr<float> (scrollHistory, out pScrollHistory);

			_AppendBufferAndShift (pBuffer, buffer.Length, pScrollHistory, scrollHistory.Length);

			fixed (float *arrAddr = &buffer [0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pBuffer, (nuint)(sizeType * buffer.Length));
			}

			fixed (float *arrAddr = &scrollHistory [0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pScrollHistory, (nuint)(sizeType * scrollHistory.Length));
			}

			Marshal.FreeHGlobal (pBuffer);
			Marshal.FreeHGlobal (pScrollHistory);
		}

		public unsafe void AppendValue (float value, float[] scrollHistory, int scrollHistoryLength)
		{
			var sizeType = Marshal.SizeOf (typeof(float));
			IntPtr pScrollHistory;
			IntPtrHelper.ConvertToIntPtr<float> (scrollHistory, out pScrollHistory);

			_AppendValue (value, pScrollHistory, scrollHistory.Length);

			fixed (float *arrAddr = &scrollHistory [0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pScrollHistory, (nuint)(sizeType * scrollHistory.Length));
			}

			Marshal.FreeHGlobal (pScrollHistory);
		}

		public unsafe float Rms (float[] buffer)
		{
			IntPtr pBuffer;
			IntPtrHelper.ConvertToIntPtr<float> (buffer, out pBuffer);
			var result = _Rms (pBuffer, buffer.Length);
			Marshal.FreeHGlobal (pBuffer);

			return result;
		}

		public unsafe void UpdateScrollHistory (float[][] scrollHistory, out int index, float[] buffer, out bool isChanging)
		{
			var sizeType = Marshal.SizeOf (typeof(float));
			var scrollHistoryLength = scrollHistory.Length;
			var scrollHistoryArraySize = sizeType * scrollHistory [0].Length;
			IntPtr pDataScrollHistory;
			IntPtr pPointerScrollHistory;
			IntPtrHelper.ConvertToIntPtr<float> (scrollHistory, out pDataScrollHistory, out pPointerScrollHistory); 

			var bufferArraySize = sizeType * buffer.Length;
			IntPtr pBuffer;
			IntPtrHelper.ConvertToIntPtr<float> (buffer, out pBuffer);

			_UpdateScrollHistory (pPointerScrollHistory, scrollHistoryLength, out index, pBuffer, buffer.Length, out isChanging);

			var pSize = Marshal.SizeOf (typeof(IntPtr));
			for (int i = 0; i < scrollHistoryLength; i++) {
				var pArray = Marshal.ReadIntPtr (IntPtr.Add (pPointerScrollHistory, i * pSize));

				fixed (float *arrAddr = &scrollHistory [i] [0]) {
					IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pArray, (nuint)scrollHistoryArraySize);
				}
			}

			fixed (float *arrAddr = &buffer [0]) {
				IntPtrHelper.MemoryCopy ((IntPtr)arrAddr, pBuffer, (nuint)bufferArraySize);
			}

			Marshal.FreeHGlobal (pDataScrollHistory);
			Marshal.FreeHGlobal (pPointerScrollHistory);
			Marshal.FreeHGlobal (pBuffer);
		}
	}

	public partial class Microphone : NSObject
	{

		//		public AudioUnit.AudioUnit AudioUnit {
		//			get {
		//				var test = _AudioUnit;
		//
		//				var audioUnit = new AudioUnit.AudioUnit ();
		//			}
		//		}

	}

	public partial class Output : NSObject
	{
		static uint? maximumFramesPerSlice;

		public static uint MaximumFramesPerSlice { 
			get {
				if (maximumFramesPerSlice != null)
					return maximumFramesPerSlice.Value;

				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "EZOutputMaximumFramesPerSlice");
				maximumFramesPerSlice = (uint)Marshal.PtrToStructure (ptr, typeof(uint));
				Dlfcn.dlclose (RTLD_MAIN_ONLY);

				return maximumFramesPerSlice.Value;
			}
		}

		// TODO: Find a way to assign the IntPtr to AUGraph class
		//		public AUGraph Graph {
		//			get {
		//				var pGraph = _Graph;
		//				var test = AUGraph.Create ();
		//			}
		//		}


		//		public AudioUnit.AudioUnit ConverterAudioUnit {
		//			get {
		//
		//			}
		//		}
		//
		//		public AudioUnit.AudioUnit MixerAudioUnit {
		//			get {
		//
		//			}
		//		}
		//
		//		public AudioUnit.AudioUnit OutputAudioUnit {
		//			get {
		//
		//			}
		//
		//				}

		public int ConnectOutputOfSourceNode (int sourceNode, uint sourceNodeOutputBus, int destinationNode, uint destinationNodeInputBus, AUGraph graph)
		{
			return _ConnectOutputOfSourceNode (sourceNode, sourceNodeOutputBus, destinationNode, destinationNodeInputBus, graph.Handle);
		}
	}

	public partial class Plot : UIView
	{
		public virtual void Clear ()
		{
			Console.WriteLine ("Please, Override in subclass");
		}

		public virtual void UpdateBuffer (float[] buffer)
		{
			Console.WriteLine ("Please, Override in subclass");
		}
	}

	public partial class Recorder : NSObject
	{
		public void AppendDataFromBufferList (AudioBuffers bufferList, uint bufferSize)
		{
			_AppendDataFromBufferList ((IntPtr)bufferList, bufferSize);
		}
	}
}