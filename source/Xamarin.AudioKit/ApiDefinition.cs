using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using AudioUnit;
using AVFoundation;
using Accelerate;
using AudioToolbox;
using CoreGraphics;
using CoreAnimation;
using GLKit;
using OpenGLES;

namespace Xamarin.AudioKit
{
	// @interface AKAmplitudeEnvelopeAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKAmplitudeEnvelopeAudioUnit")]
	interface AmplitudeEnvelopeAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKAmplitudeTrackerAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKAmplitudeTrackerAudioUnit")]
	interface AmplitudeTrackerAudioUnit
	{
		// -(float)getAmplitude;
		[Export ("getAmplitude")]
		float Amplitude { get; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKAutoWahAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKAutoWahAudioUnit")]
	interface AutoWahAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKBalancerAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKBalancerAudioUnit")]
	interface BalancerAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKBandPassButterworthFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKBandPassButterworthFilterAudioUnit")]
	interface BandPassButterworthFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKBandRejectButterworthFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKBandRejectButterworthFilterAudioUnit")]
	interface BandRejectButterworthFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKBitCrusherAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKBitCrusherAudioUnit")]
	interface BitCrusherAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKChowningReverbAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKChowningReverbAudioUnit")]
	interface ChowningReverbAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKClipperAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKClipperAudioUnit")]
	interface AKClipperAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKCombFilterReverbAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKCombFilterReverbAudioUnit")]
	interface CombFilterReverbAudioUnit
	{
		// -(void)setLoopDuration:(float)duration;
		[Export ("setLoopDuration:")]
		void SetLoopDuration (float duration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKConvolutionAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKConvolutionAudioUnit")]
	interface ConvolutionAudioUnit
	{
		// -(void)setupAudioFileTable:(float *)data size:(UInt32)size;
		[Internal]
		[Export ("setupAudioFileTable:size:")]
		unsafe void _SetupAudioFileTable (IntPtr data, uint size);

		// -(void)setPartitionLength:(int)partitionLength;
		[Export ("setPartitionLength:")]
		void SetPartitionLength (int partitionLength);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKCostelloReverbAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKCostelloReverbAudioUnit")]
	interface CostelloReverbAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKDCBlockAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKDCBlockAudioUnit")]
	interface DCBlockAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKDripAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKDripAudioUnit")]
	interface DripAudioUnit
	{
		// @property (nonatomic) float intensity;
		[Export ("intensity")]
		float Intensity { get; set; }

		// @property (nonatomic) float dampingFactor;
		[Export ("dampingFactor")]
		float DampingFactor { get; set; }

		// @property (nonatomic) float energyReturn;
		[Export ("energyReturn")]
		float EnergyReturn { get; set; }

		// @property (nonatomic) float mainResonantFrequency;
		[Export ("mainResonantFrequency")]
		float MainResonantFrequency { get; set; }

		// @property (nonatomic) float firstResonantFrequency;
		[Export ("firstResonantFrequency")]
		float FirstResonantFrequency { get; set; }

		// @property (nonatomic) float secondResonantFrequency;
		[Export ("secondResonantFrequency")]
		float SecondResonantFrequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// -(void)trigger;
		[Export ("trigger")]
		void Trigger ();

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKEqualizerFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKEqualizerFilterAudioUnit")]
	interface EqualizerFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKFlatFrequencyResponseReverbAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKFlatFrequencyResponseReverbAudioUnit")]
	interface FlatFrequencyResponseReverbAudioUnit
	{
		// -(void)setLoopDuration:(float)duration;
		[Export ("setLoopDuration:")]
		void SetLoopDuration (float duration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKFMOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKFMOscillatorAudioUnit")]
	interface FmOscillatorAudioUnit
	{
		// @property (nonatomic) float baseFrequency;
		[Export ("baseFrequency")]
		float BaseFrequency { get; set; }

		// @property (nonatomic) float carrierMultiplier;
		[Export ("carrierMultiplier")]
		float CarrierMultiplier { get; set; }

		// @property (nonatomic) float modulatingMultiplier;
		[Export ("modulatingMultiplier")]
		float ModulatingMultiplier { get; set; }

		// @property (nonatomic) float modulationIndex;
		[Export ("modulationIndex")]
		float ModulationIndex { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// -(void)setupWaveform:(int)size;
		[Export ("setupWaveform:")]
		void SetupWaveform (int size);

		// -(void)setWaveformValue:(float)value atIndex:(UInt32)index;
		[Export ("setWaveformValue:atIndex:")]
		void SetWaveformValue (float value, uint index);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	[BaseType (typeof(AUAudioUnit), Name = "AKFormantFilterAudioUnit")]
	interface FormantFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKFrequencyTrackerAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKFrequencyTrackerAudioUnit")]
	interface FrequencyTrackerAudioUnit
	{
		// -(float)getAmplitude;
		[Export ("getAmplitude")]
		float Amplitude { get; }

		// -(float)getFrequency;
		[Export ("getFrequency")]
		float Frequency { get; }

		// -(void)setFrequencyLimitsWithMinimum:(float)minimum maximum:(float)maximum;
		[Export ("setFrequencyLimitsWithMinimum:maximum:")]
		void SetFrequencyLimits (float minimum, float maximum);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKHighPassButterworthFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKHighPassButterworthFilterAudioUnit")]
	interface HighPassButterworthFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKHighShelfParametricEqualizerFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKHighShelfParametricEqualizerFilterAudioUnit")]
	interface HighShelfParametricEqualizerFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKLowPassButterworthFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKLowPassButterworthFilterAudioUnit")]
	interface LowPassButterworthFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKLowShelfParametricEqualizerFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKLowShelfParametricEqualizerFilterAudioUnit")]
	interface LowShelfParametricEqualizerFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKModalResonanceFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKModalResonanceFilterAudioUnit")]
	interface ModalResonanceFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKMoogLadderAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKMoogLadderAudioUnit")]
	interface MoogLadderAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// -(void)setUpParameterRamp;
		[Export ("setUpParameterRamp")]
		void SetUpParameterRamp ();

		// @property double inertia;
		[Export ("inertia")]
		double Inertia { get; set; }
	}

	// @interface AKMorphingOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKMorphingOscillatorAudioUnit")]
	interface MorphingOscillatorAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float index;
		[Export ("index")]
		float Index { get; set; }

		// @property (nonatomic) float detuningOffset;
		[Export ("detuningOffset")]
		float DetuningOffset { get; set; }

		// @property (nonatomic) float detuningMultiplier;
		[Export ("detuningMultiplier")]
		float DetuningMultiplier { get; set; }

		// -(void)setupWaveform:(UInt32)waveform size:(int)size;
		[Export ("setupWaveform:size:")]
		void SetupWaveform (uint waveform, int size);

		// -(void)setWaveform:(UInt32)waveform withValue:(float)value atIndex:(UInt32)index;
		[Export ("setWaveform:withValue:atIndex:")]
		void SetWaveform (uint waveform, float value, uint index);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKOperationEffectAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKOperationEffectAudioUnit")]
	interface OperationEffectAudioUnit
	{
		// -(void)setSporth:(NSString *)sporth;
		[Export ("setSporth:")]
		void SetSporth (string sporth);

		// -(void)setParameters:(NSArray *)parameters;
		[Internal]
		[Export ("setParameters:")]
		void _SetParameters (NSNumber[] parameters);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKOperationGeneratorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKOperationGeneratorAudioUnit")]
	interface OperationGeneratorAudioUnit
	{
		// -(void)setSporth:(NSString *)sporth;
		[Export ("setSporth:")]
		void SetSporth (string sporth);

		// -(void)trigger:(NSArray *)parameters;
		[Internal]
		[Export ("trigger:")]
		void _Trigger (NSNumber[] parameters);

		// -(void)setParameters:(NSArray *)parameters;
		[Internal]
		[Export ("setParameters:")]
		void _SetParameters (NSNumber[] parameters);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKOscillatorAudioUnit")]
	interface OscillatorAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float detuningOffset;
		[Export ("detuningOffset")]
		float DetuningOffset { get; set; }

		// @property (nonatomic) float detuningMultiplier;
		[Export ("detuningMultiplier")]
		float DetuningMultiplier { get; set; }

		// -(void)setupWaveform:(int)size;
		[Export ("setupWaveform:")]
		void SetupWaveform (int size);

		// -(void)setWaveformValue:(float)value atIndex:(UInt32)index;
		[Export ("setWaveformValue:atIndex:")]
		void SetWaveformValue (float value, uint index);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKPannerAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKPannerAudioUnit")]
	interface PannerAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKPeakingParametricEqualizerFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKPeakingParametricEqualizerFilterAudioUnit")]
	interface PeakingParametricEqualizerFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKPhaseLockedVocoderAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKPhaseLockedVocoderAudioUnit")]
	interface PhaseLockedVocoderAudioUnit
	{
		// @property (nonatomic) float position;
		[Export ("position")]
		float Position { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float pitchRatio;
		[Export ("pitchRatio")]
		float PitchRatio { get; set; }

		// -(void)setupAudioFileTable:(float *)data size:(UInt32)size;
		[Internal]
		[Export ("setupAudioFileTable:size:")]
		unsafe void _SetupAudioFileTable (IntPtr data, uint size);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKPinkNoiseAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKPinkNoiseAudioUnit")]
	interface PinkNoiseAudioUnit
	{
		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKPluckedStringAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKPluckedStringAudioUnit")]
	interface PluckedStringAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// -(void)triggerFrequency:(float)frequency amplitude:(float)amplitude;
		[Export ("triggerFrequency:amplitude:")]
		void TriggerFrequency (float frequency, float amplitude);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKRolandTB303FilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKRolandTB303FilterAudioUnit")]
	interface RolandTB303FilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKSawtoothOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKSawtoothOscillatorAudioUnit")]
	interface SawtoothOscillatorAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float detuningOffset;
		[Export ("detuningOffset")]
		float DetuningOffset { get; set; }

		// @property (nonatomic) float detuningMultiplier;
		[Export ("detuningMultiplier")]
		float DetuningMultiplier { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKSquareWaveOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKSquareWaveOscillatorAudioUnit")]
	interface SquareWaveOscillatorAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float pulseWidth;
		[Export ("pulseWidth")]
		float PulseWidth { get; set; }

		// @property (nonatomic) float detuningOffset;
		[Export ("detuningOffset")]
		float DetuningOffset { get; set; }

		// @property (nonatomic) float detuningMultiplier;
		[Export ("detuningMultiplier")]
		float DetuningMultiplier { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKStringResonatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKStringResonatorAudioUnit")]
	interface StringResonatorAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKTanhDistortionAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKTanhDistortionAudioUnit")]
	interface TanhDistortionAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKTesterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKTesterAudioUnit")]
	interface TesterAudioUnit
	{
		// -(int)getSamples;
		// -(void)setSamples:(int)samples;
		[Export ("samples")]
		int Samples { [Bind ("getSamples")] get; set; }

		// -(NSString *)getMD5;
		[Export ("getMD5")]
		string MD5 { get; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKThreePoleLowpassFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKThreePoleLowpassFilterAudioUnit")]
	interface ThreePoleLowpassFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKToneComplementFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKToneComplementFilterAudioUnit")]
	interface ToneComplementFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKToneFilterAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKToneFilterAudioUnit")]
	interface ToneFilterAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKTriangleOscillatorAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKTriangleOscillatorAudioUnit")]
	interface TriangleOscillatorAudioUnit
	{
		// @property (nonatomic) float frequency;
		[Export ("frequency")]
		float Frequency { get; set; }

		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// @property (nonatomic) float detuningOffset;
		[Export ("detuningOffset")]
		float DetuningOffset { get; set; }

		// @property (nonatomic) float detuningMultiplier;
		[Export ("detuningMultiplier")]
		float DetuningMultiplier { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKVariableDelayAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKVariableDelayAudioUnit")]
	interface VariableDelayAudioUnit
	{
		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKWhiteNoiseAudioUnit : AUAudioUnit
	[BaseType (typeof(AUAudioUnit), Name = "AKWhiteNoiseAudioUnit")]
	interface WhiteNoiseAudioUnit
	{
		// @property (nonatomic) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(BOOL)isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }
	}

	// @interface AKNode : NSObject
	[BaseType (typeof(NSObject), Name = "AKNode")]
	interface Node
	{
		// @property (nonatomic, strong) AVAudioNode * __nonnull avAudioNode;
		[Export ("avAudioNode", ArgumentSemantic.Strong)]
		AVAudioNode AudioNode { get; set; }

		// - (void)addConnectionPoint:(AKNode * __nonnull)node;
		[Export ("addConnectionPoint:")]
		void AddConnectionPoint (Node node);
	}

	// @interface AKAmplitudeEnvelope : AKNode
	[BaseType (typeof(Node), Name = "AKAmplitudeEnvelope")]
	interface AmplitudeEnvelope
	{
		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input attackDuration:(double)attackDuration decayDuration:(double)decayDuration sustainLevel:(double)sustainLevel releaseDuration:(double)releaseDuration __attribute__((objc_designated_initializer));
		[Export ("init:attackDuration:decayDuration:sustainLevel:releaseDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double attackDuration, double decayDuration, double sustainLevel, double releaseDuration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKAmplitudeTracker : AKNode
	[BaseType (typeof(Node), Name = "AKAmplitudeTracker")]
	interface AmplitudeTracker
	{
		// @property (nonatomic) double halfPowerPoint;
		[Export ("halfPowerPoint")]
		double HalfPowerPoint { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (readonly, nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input halfPowerPoint:(double)halfPowerPoint __attribute__((objc_designated_initializer));
		[Export ("init:halfPowerPoint:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double halfPowerPoint);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKAudioPlayer : AKNode
	[BaseType (typeof(Node), Name = "AKAudioPlayer")]
	interface AudioPlayer
	{
		// @property (nonatomic) BOOL looping;
		[Export ("looping")]
		bool Looping { get; set; }

		// @property (nonatomic) double volume;
		[Export ("volume")]
		double Volume { get; set; }

		// @property (nonatomic) double pan;
		[Export ("pan")]
		double Pan { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(NSString * _Nonnull)file __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (string file);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKAutoWah : AKNode
	[BaseType (typeof(Node), Name = "AKAutoWah")]
	interface AutoWah
	{
		// @property (nonatomic) double wah;
		[Export ("wah")]
		double Wah { get; set; }

		// @property (nonatomic) double mix;
		[Export ("mix")]
		double Mix { get; set; }

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input wah:(double)wah mix:(double)mix amplitude:(double)amplitude __attribute__((objc_designated_initializer));
		[Export ("init:wah:mix:amplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double wah, double mix, double amplitude);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBalancer : AKNode
	[BaseType (typeof(Node), Name = "AKBalancer")]
	interface Balancer
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input comparator:(AKNode * _Nonnull)comparator __attribute__((objc_designated_initializer));
		[Export ("init:comparator:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, Node comparator);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBandPassButterworthFilter : AKNode
	[BaseType (typeof(Node), Name = "AKBandPassButterworthFilter")]
	interface BandPassButterworthFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double bandwidth;
		[Export ("bandwidth")]
		double Bandwidth { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency bandwidth:(double)bandwidth __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:bandwidth:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double bandwidth);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBandPassFilter : AKNode
	[BaseType (typeof(Node), Name = "AKBandPassFilter")]
	interface BandPassFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double bandwidth;
		[Export ("bandwidth")]
		double Bandwidth { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency bandwidth:(double)bandwidth __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:bandwidth:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double bandwidth);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBandRejectButterworthFilter : AKNode
	[BaseType (typeof(Node), Name = "AKBandRejectButterworthFilter")]
	interface BandRejectButterworthFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double bandwidth;
		[Export ("bandwidth")]
		double Bandwidth { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency bandwidth:(double)bandwidth __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:bandwidth:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double bandwidth);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBitCrusher : AKNode
	[BaseType (typeof(Node), Name = "AKBitCrusher")]
	interface BitCrusher
	{
		// @property (nonatomic) double bitDepth;
		[Export ("bitDepth")]
		double BitDepth { get; set; }

		// @property (nonatomic) double sampleRate;
		[Export ("sampleRate")]
		double SampleRate { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input bitDepth:(double)bitDepth sampleRate:(double)sampleRate __attribute__((objc_designated_initializer));
		[Export ("init:bitDepth:sampleRate:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double bitDepth, double sampleRate);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKBooster : AKNode
	[BaseType (typeof(Node), Name = "AKBooster")]
	interface Booster
	{
		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input gain:(double)gain __attribute__((objc_designated_initializer));
		[Export ("init:gain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double gain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKChowningReverb : AKNode
	[BaseType (typeof(Node), Name = "AKChowningReverb")]
	interface ChowningReverb
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKClipper : AKNode
	[BaseType (typeof(Node), Name = "AKClipper")]
	interface Clipper
	{
		// @property (nonatomic) double limit;
		[Export ("limit")]
		double Limit { get; set; }

		// @property (nonatomic) double clippingStartPoint;
		[Export ("clippingStartPoint")]
		double ClippingStartPoint { get; set; }

		// @property (nonatomic) double method;
		[Export ("method")]
		double Method { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input limit:(double)limit clippingStartPoint:(double)clippingStartPoint method:(double)method __attribute__((objc_designated_initializer));
		[Export ("init:limit:clippingStartPoint:method:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double limit, double clippingStartPoint, double method);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKCombFilterReverb : AKNode
	[BaseType (typeof(Node), Name = "AKCombFilterReverb")]
	interface CombFilterReverb
	{
		// @property (nonatomic) double reverbDuration;
		[Export ("reverbDuration")]
		double ReverbDuration { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input reverbDuration:(double)reverbDuration loopDuration:(double)loopDuration __attribute__((objc_designated_initializer));
		[Export ("init:reverbDuration:loopDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double reverbDuration, double loopDuration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKCompressor : AKNode
	[BaseType (typeof(Node), Name = "AKCompressor")]
	interface AKCompressor
	{
		// @property (nonatomic) double threshold;
		[Export ("threshold")]
		double Threshold { get; set; }

		// @property (nonatomic) double headRoom;
		[Export ("headRoom")]
		double HeadRoom { get; set; }

		// @property (nonatomic) double attackTime;
		[Export ("attackTime")]
		double AttackTime { get; set; }

		// @property (nonatomic) double releaseTime;
		[Export ("releaseTime")]
		double ReleaseTime { get; set; }

		// @property (readonly, nonatomic) double compressionAmount;
		[Export ("compressionAmount")]
		double CompressionAmount { get; }

		// @property (readonly, nonatomic) double inputAmplitude;
		[Export ("inputAmplitude")]
		double InputAmplitude { get; }

		// @property (readonly, nonatomic) double outputAmplitude;
		[Export ("outputAmplitude")]
		double OutputAmplitude { get; }

		// @property (nonatomic) double masterGain;
		[Export ("masterGain")]
		double MasterGain { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input threshold:(double)threshold headRoom:(double)headRoom attackTime:(double)attackTime releaseTime:(double)releaseTime masterGain:(double)masterGain __attribute__((objc_designated_initializer));
		[Export ("init:threshold:headRoom:attackTime:releaseTime:masterGain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double threshold, double headRoom, double attackTime, double releaseTime, double masterGain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKConvolution : AKNode
	[BaseType (typeof(Node), Name = "AKConvolution")]
	interface Convolution
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input impulseResponseFileURL:(NSURL * _Nonnull)impulseResponseFileURL partitionLength:(NSInteger)partitionLength __attribute__((objc_designated_initializer));
		[Export ("init:impulseResponseFileURL:partitionLength:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, NSUrl impulseResponseFileURL, nint partitionLength);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKCostelloReverb : AKNode
	[BaseType (typeof(Node), Name = "AKCostelloReverb")]
	interface CostelloReverb
	{
		// @property (nonatomic) double feedback;
		[Export ("feedback")]
		double Feedback { get; set; }

		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input feedback:(double)feedback cutoffFrequency:(double)cutoffFrequency __attribute__((objc_designated_initializer));
		[Export ("init:feedback:cutoffFrequency:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double feedback, double cutoffFrequency);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDCBlock : AKNode
	[BaseType (typeof(Node), Name = "AKDCBlock")]
	interface DcBlock
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDecimator : AKNode
	[BaseType (typeof(Node), Name = "AKDecimator")]
	interface Decimator
	{
		// @property (nonatomic) double decimation;
		[Export ("decimation")]
		double Decimation { get; set; }

		// @property (nonatomic) double rounding;
		[Export ("rounding")]
		double Rounding { get; set; }

		// @property (nonatomic) double mix;
		[Export ("mix")]
		double Mix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input decimation:(double)decimation rounding:(double)rounding mix:(double)mix __attribute__((objc_designated_initializer));
		[Export ("init:decimation:rounding:mix:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double decimation, double rounding, double mix);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDelay : AKNode
	[BaseType (typeof(Node), Name = "AKDelay")]
	interface Delay
	{
		// @property (nonatomic) NSTimeInterval time;
		[Export ("time")]
		double Time { get; set; }

		// @property (nonatomic) double feedback;
		[Export ("feedback")]
		double Feedback { get; set; }

		// @property (nonatomic) double lowPassCutoff;
		[Export ("lowPassCutoff")]
		double LowPassCutoff { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input time:(double)time feedback:(double)feedback lowPassCutoff:(double)lowPassCutoff dryWetMix:(double)dryWetMix __attribute__((objc_designated_initializer));
		[Export ("init:time:feedback:lowPassCutoff:dryWetMix:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double time, double feedback, double lowPassCutoff, double dryWetMix);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDistortion : AKNode
	[BaseType (typeof(Node), Name = "AKDistortion")]
	interface Distortion
	{
		// @property (nonatomic) double delay;
		[Export ("delay")]
		double Delay { get; set; }

		// @property (nonatomic) double decay;
		[Export ("decay")]
		double Decay { get; set; }

		// @property (nonatomic) double delayMix;
		[Export ("delayMix")]
		double DelayMix { get; set; }

		// @property (nonatomic) double decimation;
		[Export ("decimation")]
		double Decimation { get; set; }

		// @property (nonatomic) double rounding;
		[Export ("rounding")]
		double Rounding { get; set; }

		// @property (nonatomic) double decimationMix;
		[Export ("decimationMix")]
		double DecimationMix { get; set; }

		// @property (nonatomic) double linearTerm;
		[Export ("linearTerm")]
		double LinearTerm { get; set; }

		// @property (nonatomic) double squaredTerm;
		[Export ("squaredTerm")]
		double SquaredTerm { get; set; }

		// @property (nonatomic) double cubicTerm;
		[Export ("cubicTerm")]
		double CubicTerm { get; set; }

		// @property (nonatomic) double polynomialMix;
		[Export ("polynomialMix")]
		double PolynomialMix { get; set; }

		// @property (nonatomic) double ringModFreq1;
		[Export ("ringModFreq1")]
		double RingModFreq1 { get; set; }

		// @property (nonatomic) double ringModFreq2;
		[Export ("ringModFreq2")]
		double RingModFreq2 { get; set; }

		// @property (nonatomic) double ringModBalance;
		[Export ("ringModBalance")]
		double RingModBalance { get; set; }

		// @property (nonatomic) double ringModMix;
		[Export ("ringModMix")]
		double RingModMix { get; set; }

		// @property (nonatomic) double softClipGain;
		[Export ("softClipGain")]
		double SoftClipGain { get; set; }

		// @property (nonatomic) double finalMix;
		[Export ("finalMix")]
		double FinalMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input delay:(double)delay decay:(double)decay delayMix:(double)delayMix decimation:(double)decimation rounding:(double)rounding decimationMix:(double)decimationMix linearTerm:(double)linearTerm squaredTerm:(double)squaredTerm cubicTerm:(double)cubicTerm polynomialMix:(double)polynomialMix ringModFreq1:(double)ringModFreq1 ringModFreq2:(double)ringModFreq2 ringModBalance:(double)ringModBalance ringModMix:(double)ringModMix softClipGain:(double)softClipGain finalMix:(double)finalMix __attribute__((objc_designated_initializer));
		[Export ("init:delay:decay:delayMix:decimation:rounding:decimationMix:linearTerm:squaredTerm:cubicTerm:polynomialMix:ringModFreq1:ringModFreq2:ringModBalance:ringModMix:softClipGain:finalMix:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double delay, double decay, double delayMix, double decimation, double rounding, double decimationMix, double linearTerm, double squaredTerm, double cubicTerm, double polynomialMix, double ringModFreq1, double ringModFreq2, double ringModBalance, double ringModMix, double softClipGain, double finalMix);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDrip : AKNode
	[BaseType (typeof(Node), Name = "AKDrip")]
	interface Drip
	{
		// @property (nonatomic) double intensity;
		[Export ("intensity")]
		double Intensity { get; set; }

		// -(void)rampWithIntensity:(double)intensity;
		[Export ("rampWithIntensity:")]
		void RampWithIntensity (double intensity);

		// @property (nonatomic) double dampingFactor;
		[Export ("dampingFactor")]
		double DampingFactor { get; set; }

		// -(void)rampWithDampingFactor:(double)dampingFactor;
		[Export ("rampWithDampingFactor:")]
		void RampWithDampingFactor (double dampingFactor);

		// @property (nonatomic) double energyReturn;
		[Export ("energyReturn")]
		double EnergyReturn { get; set; }

		// -(void)rampWithEnergyReturn:(double)energyReturn;
		[Export ("rampWithEnergyReturn:")]
		void RampWithEnergyReturn (double energyReturn);

		// @property (nonatomic) double mainResonantFrequency;
		[Export ("mainResonantFrequency")]
		double MainResonantFrequency { get; set; }

		// -(void)rampWithMainResonantFrequency:(double)mainResonantFrequency;
		[Export ("rampWithMainResonantFrequency:")]
		void RampWithMainResonantFrequency (double mainResonantFrequency);

		// @property (nonatomic) double firstResonantFrequency;
		[Export ("firstResonantFrequency")]
		double FirstResonantFrequency { get; set; }

		// -(void)rampWithFirstResonantFrequency:(double)firstResonantFrequency;
		[Export ("rampWithFirstResonantFrequency:")]
		void RampWithFirstResonantFrequency (double firstResonantFrequency);

		// @property (nonatomic) double secondResonantFrequency;
		[Export ("secondResonantFrequency")]
		double SecondResonantFrequency { get; set; }

		// -(void)rampWithSecondResonantFrequency:(double)secondResonantFrequency;
		[Export ("rampWithSecondResonantFrequency:")]
		void RampWithSecondResonantFrequency (double secondResonantFrequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithIntensity:(double)intensity dampingFactor:(double)dampingFactor energyReturn:(double)energyReturn mainResonantFrequency:(double)mainResonantFrequency firstResonantFrequency:(double)firstResonantFrequency secondResonantFrequency:(double)secondResonantFrequency amplitude:(double)amplitude __attribute__((objc_designated_initializer));
		[Export ("initWithIntensity:dampingFactor:energyReturn:mainResonantFrequency:firstResonantFrequency:secondResonantFrequency:amplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (double intensity, double dampingFactor, double energyReturn, double mainResonantFrequency, double firstResonantFrequency, double secondResonantFrequency, double amplitude);

		// -(void)trigger;
		[Export ("trigger")]
		void Trigger ();

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKDryWetMixer : AKNode
	[BaseType (typeof(Node), Name = "AKDryWetMixer")]
	interface DryWetMixer
	{
		// @property (nonatomic) double balance;
		[Export ("balance")]
		double Balance { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)dry :(AKNode * _Nonnull)wet balance:(double)balance __attribute__((objc_designated_initializer));
		[Export ("init::balance:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node dry, Node wet, double balance);
	}

	// @interface AKDynamicsProcessor : AKNode
	[BaseType (typeof(Node), Name = "AKDynamicsProcessor")]
	interface DynamicsProcessor
	{
		// @property (nonatomic) double threshold;
		[Export ("threshold")]
		double Threshold { get; set; }

		// @property (nonatomic) double headRoom;
		[Export ("headRoom")]
		double HeadRoom { get; set; }

		// @property (nonatomic) double expansionRatio;
		[Export ("expansionRatio")]
		double ExpansionRatio { get; set; }

		// @property (nonatomic) double expansionThreshold;
		[Export ("expansionThreshold")]
		double ExpansionThreshold { get; set; }

		// @property (nonatomic) double attackTime;
		[Export ("attackTime")]
		double AttackTime { get; set; }

		// @property (nonatomic) double releaseTime;
		[Export ("releaseTime")]
		double ReleaseTime { get; set; }

		// @property (nonatomic) double masterGain;
		[Export ("masterGain")]
		double MasterGain { get; set; }

		// @property (readonly, nonatomic) double compressionAmount;
		[Export ("compressionAmount")]
		double CompressionAmount { get; }

		// @property (readonly, nonatomic) double inputAmplitude;
		[Export ("inputAmplitude")]
		double InputAmplitude { get; }

		// @property (readonly, nonatomic) double outputAmplitude;
		[Export ("outputAmplitude")]
		double OutputAmplitude { get; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input threshold:(double)threshold headRoom:(double)headRoom expansionRatio:(double)expansionRatio expansionThreshold:(double)expansionThreshold attackTime:(double)attackTime releaseTime:(double)releaseTime masterGain:(double)masterGain compressionAmount:(double)compressionAmount inputAmplitude:(double)inputAmplitude outputAmplitude:(double)outputAmplitude __attribute__((objc_designated_initializer));
		[Export ("init:threshold:headRoom:expansionRatio:expansionThreshold:attackTime:releaseTime:masterGain:compressionAmount:inputAmplitude:outputAmplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double threshold, double headRoom, double expansionRatio, double expansionThreshold, double attackTime, double releaseTime, double masterGain, double compressionAmount, double inputAmplitude, double outputAmplitude);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKEqualizerFilter : AKNode
	[BaseType (typeof(Node), Name = "AKEqualizerFilter")]
	interface EqualizerFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double bandwidth;
		[Export ("bandwidth")]
		double Bandwidth { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency bandwidth:(double)bandwidth gain:(double)gain __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:bandwidth:gain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double bandwidth, double gain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKExpander : AKNode
	[BaseType (typeof(Node), Name = "AKExpander")]
	interface Expander
	{
		// @property (nonatomic) double expansionRatio;
		[Export ("expansionRatio")]
		double ExpansionRatio { get; set; }

		// @property (nonatomic) double expansionThreshold;
		[Export ("expansionThreshold")]
		double ExpansionThreshold { get; set; }

		// @property (nonatomic) double attackTime;
		[Export ("attackTime")]
		double AttackTime { get; set; }

		// @property (nonatomic) double releaseTime;
		[Export ("releaseTime")]
		double ReleaseTime { get; set; }

		// @property (nonatomic) double masterGain;
		[Export ("masterGain")]
		double MasterGain { get; set; }

		// @property (readonly, nonatomic) double compressionAmount;
		[Export ("compressionAmount")]
		double CompressionAmount { get; }

		// @property (readonly, nonatomic) double inputAmplitude;
		[Export ("inputAmplitude")]
		double InputAmplitude { get; }

		// @property (readonly, nonatomic) double outputAmplitude;
		[Export ("outputAmplitude")]
		double OutputAmplitude { get; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input threshold:(double)threshold headRoom:(double)headRoom expansionRatio:(double)expansionRatio expansionThreshold:(double)expansionThreshold attackTime:(double)attackTime releaseTime:(double)releaseTime masterGain:(double)masterGain compressionAmount:(double)compressionAmount inputAmplitude:(double)inputAmplitude outputAmplitude:(double)outputAmplitude __attribute__((objc_designated_initializer));
		[Export ("init:threshold:headRoom:expansionRatio:expansionThreshold:attackTime:releaseTime:masterGain:compressionAmount:inputAmplitude:outputAmplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double threshold, double headRoom, double expansionRatio, double expansionThreshold, double attackTime, double releaseTime, double masterGain, double compressionAmount, double inputAmplitude, double outputAmplitude);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKFFT : NSObject
	[BaseType (typeof(NSObject), Name = "AKFFT")]
	interface Fft : EZAudio.AudioFftDelegate
	{
		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull fftData;
		[Export ("fftData", ArgumentSemantic.Copy)]
		NSNumber[] FftData { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input);

		// -(void)fft:(EZAudioFFT * _Null_unspecified)fft updatedWithFFTData:(float * _Null_unspecified)fftData bufferSize:(vDSP_Length)bufferSize;
		[Internal]
		[Export ("fft:updatedWithFFTData:bufferSize:")]
		unsafe void _FftComputation (EZAudio.AudioFft fft, IntPtr fftData, nuint bufferSize);
	}

	// @interface AKVoice : AKNode
	[BaseType (typeof(Node), Name = "AKVoice")]
	interface Voice
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(AKVoice * _Nonnull)duplicate;
		[Export ("duplicate")]
		Voice Duplicate { get; }
	}

	// @interface AKFMOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKFMOscillator")]
	interface FmOscillator
	{
		// @property (nonatomic) double baseFrequency;
		[Export ("baseFrequency")]
		double BaseFrequency { get; set; }

		// -(void)rampWithBaseFrequency:(double)baseFrequency;
		[Export ("rampWithBaseFrequency:")]
		void RampWithBaseFrequency (double baseFrequency);

		// @property (nonatomic) double carrierMultiplier;
		[Export ("carrierMultiplier")]
		double CarrierMultiplier { get; set; }

		// -(void)rampWithCarrierMultiplier:(double)carrierMultiplier;
		[Export ("rampWithCarrierMultiplier:")]
		void RampWithCarrierMultiplier (double carrierMultiplier);

		// @property (nonatomic) double modulatingMultiplier;
		[Export ("modulatingMultiplier")]
		double ModulatingMultiplier { get; set; }

		// -(void)rampWithModulatingMultiplier:(double)modulatingMultiplier;
		[Export ("rampWithModulatingMultiplier:")]
		void RampWithModulatingMultiplier (double modulatingMultiplier);

		// @property (nonatomic) double modulationIndex;
		[Export ("modulationIndex")]
		double ModulationIndex { get; set; }

		// -(void)rampWithModulationIndex:(double)modulationIndex;
		[Export ("rampWithModulationIndex:")]
		void RampWithModulationIndex (double modulationIndex);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPolyphonicInstrument : AKNode
	[BaseType (typeof(Node), Name = "AKPolyphonicInstrument")]
	interface PolyphonicInstrument
	{
		// @property (readonly, copy, nonatomic) NSArray<AKVoice *> * _Nonnull voices;
		[Export ("voices", ArgumentSemantic.Copy)]
		Voice[] Voices { get; }

		// @property (copy, nonatomic) NSArray<AKVoice *> * _Nonnull availableVoices;
		[Export ("availableVoices", ArgumentSemantic.Copy)]
		Voice[] AvailableVoices { get; set; }

		// @property (copy, nonatomic) NSArray<AKVoice *> * _Nonnull activeVoices;
		[Export ("activeVoices", ArgumentSemantic.Copy)]
		Voice[] ActiveVoices { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull activeNotes;
		[Export ("activeNotes", ArgumentSemantic.Copy)]
		NSNumber[] ActiveNotes { get; set; }

		// @property (nonatomic) double volume;
		[Export ("volume")]
		double Volume { get; set; }

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(instancetype _Nonnull)initWithVoice:(AKVoice * _Nonnull)voice voiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoice:voiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (Voice voice, nint voiceCount);

		// -(void)playNote:(NSInteger)note velocity:(NSInteger)velocity;
		[Export ("playNote:velocity:")]
		void PlayNote (nint note, nint velocity);

		// -(void)stopNote:(NSInteger)note;
		[Export ("stopNote:")]
		void StopNote (nint note);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);

		// -(void)panic;
		[Export ("panic")]
		void Panic ();
	}

	// @interface AKFMSynth : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKFMSynth")]
	interface FmSynth
	{
		// @property (nonatomic) double carrierMultiplier;
		[Export ("carrierMultiplier")]
		double CarrierMultiplier { get; set; }

		// @property (nonatomic) double modulatingMultiplier;
		[Export ("modulatingMultiplier")]
		double ModulatingMultiplier { get; set; }

		// @property (nonatomic) double modulationIndex;
		[Export ("modulationIndex")]
		double ModulationIndex { get; set; }

		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// -(instancetype _Nonnull)initWithVoiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint voiceCount);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKFlatFrequencyResponseReverb : AKNode
	[BaseType (typeof(Node), Name = "AKFlatFrequencyResponseReverb")]
	interface FlatFrequencyResponseReverb
	{
		// @property (nonatomic) double reverbDuration;
		[Export ("reverbDuration")]
		double ReverbDuration { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input reverbDuration:(double)reverbDuration loopDuration:(double)loopDuration __attribute__((objc_designated_initializer));
		[Export ("init:reverbDuration:loopDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double reverbDuration, double loopDuration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKFormantFilter : AKNode
	[BaseType (typeof(Node), Name = "AKFormantFilter")]
	interface FormantFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency attackDuration:(double)attackDuration decayDuration:(double)decayDuration __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:attackDuration:decayDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double attackDuration, double decayDuration);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKFrequencyTracker : AKNode
	[BaseType (typeof(Node), Name = "AKFrequencyTracker")]
	interface FrequencyTracker
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (readonly, nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; }

		// @property (readonly, nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input minimumFrequency:(double)minimumFrequency maximumFrequency:(double)maximumFrequency __attribute__((objc_designated_initializer));
		[Export ("init:minimumFrequency:maximumFrequency:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double minimumFrequency, double maximumFrequency);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKHighPassButterworthFilter : AKNode
	[BaseType (typeof(Node), Name = "AKHighPassButterworthFilter")]
	interface HighPassButterworthFilter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKHighPassFilter : AKNode
	[BaseType (typeof(Node), Name = "AKHighPassFilter")]
	interface HighPassFilter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double resonance;
		[Export ("resonance")]
		double Resonance { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency resonance:(double)resonance __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:resonance:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency, double resonance);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKHighShelfFilter : AKNode
	[BaseType (typeof(Node), Name = "AKHighShelfFilter")]
	interface HighShelfFilter
	{
		// @property (nonatomic) double cutOffFrequency;
		[Export ("cutOffFrequency")]
		double CutOffFrequency { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutOffFrequency:(double)cutOffFrequency gain:(double)gain __attribute__((objc_designated_initializer));
		[Export ("init:cutOffFrequency:gain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutOffFrequency, double gain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKHighShelfParametricEqualizerFilter : AKNode
	[BaseType (typeof(Node), Name = "AKHighShelfParametricEqualizerFilter")]
	interface HighShelfParametricEqualizerFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double q;
		[Export ("q")]
		double Q { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency gain:(double)gain q:(double)q __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:gain:q:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double gain, double q);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKLowPassButterworthFilter : AKNode
	[BaseType (typeof(Node), Name = "AKLowPassButterworthFilter")]
	interface LowPassButterworthFilter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKLowPassFilter : AKNode
	[BaseType (typeof(Node), Name = "AKLowPassFilter")]
	interface LowPassFilter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double resonance;
		[Export ("resonance")]
		double Resonance { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency resonance:(double)resonance __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:resonance:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency, double resonance);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKLowShelfFilter : AKNode
	[BaseType (typeof(Node), Name = "AKLowShelfFilter")]
	interface LowShelfFilter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency gain:(double)gain __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:gain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency, double gain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKLowShelfParametricEqualizerFilter : AKNode
	[BaseType (typeof(Node), Name = "AKLowShelfParametricEqualizerFilter")]
	interface LowShelfParametricEqualizerFilter
	{
		// @property (nonatomic) double cornerFrequency;
		[Export ("cornerFrequency")]
		double CornerFrequency { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double q;
		[Export ("q")]
		double Q { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cornerFrequency:(double)cornerFrequency gain:(double)gain q:(double)q __attribute__((objc_designated_initializer));
		[Export ("init:cornerFrequency:gain:q:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cornerFrequency, double gain, double q);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKMIDIInstrument : AKNode
	[BaseType (typeof(Node), Name = "AKMIDIInstrument")]
	interface MidiInstrument
	{
		// @property (nonatomic) MIDIEndpointRef midiIn;
		[Export ("midiIn")]
		uint MidiIn { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// -(instancetype _Nonnull)initWithInstrument:(AKPolyphonicInstrument * _Nonnull)instrument __attribute__((objc_designated_initializer));
		[Export ("initWithInstrument:")]
		[DesignatedInitializer]
		IntPtr Constructor (PolyphonicInstrument instrument);

		// -(void)enableMIDI:(MIDIClientRef)midiClient name:(NSString * _Nonnull)name;
		[Export ("enableMIDI:name:")]
		void EnableMIDI (uint midiClient, string name);

		// -(void)midiNoteOn:(NSInteger)note velocity:(NSInteger)velocity channel:(NSInteger)channel;
		[Export ("midiNoteOn:velocity:channel:")]
		void MidiNoteOn (nint note, nint velocity, nint channel);

		// -(void)startNote:(NSInteger)note withVelocity:(NSInteger)velocity onChannel:(NSInteger)channel;
		[Export ("startNote:withVelocity:onChannel:")]
		void StartNote (nint note, nint velocity, nint channel);

		// -(void)stopNote:(NSInteger)note onChannel:(NSInteger)channel;
		[Export ("stopNote:onChannel:")]
		void StopNote (nint note, nint channel);
	}

	// @interface AKMicrophone : AKNode
	[BaseType (typeof(Node), Name = "AKMicrophone")]
	interface Microphone
	{
		// @property (nonatomic) double volume;
		[Export ("volume")]
		double Volume { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKMixer : AKNode
	[BaseType (typeof(Node), Name = "AKMixer")]
	interface Mixer
	{
		// @property (nonatomic) double volume;
		[Export ("volume")]
		double Volume { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(void)connect:(AKNode * _Nonnull)input;
		[Export ("connect:")]
		void Connect (Node input);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKModalResonanceFilter : AKNode
	[BaseType (typeof(Node), Name = "AKModalResonanceFilter")]
	interface ModalResonanceFilter
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// @property (nonatomic) double qualityFactor;
		[Export ("qualityFactor")]
		double QualityFactor { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input frequency:(double)frequency qualityFactor:(double)qualityFactor __attribute__((objc_designated_initializer));
		[Export ("init:frequency:qualityFactor:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double frequency, double qualityFactor);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKMoogLadder : AKNode
	[BaseType (typeof(Node), Name = "AKMoogLadder")]
	interface MoogLadder
	{
		// @property (nonatomic) double inertia;
		[Export ("inertia")]
		double Inertia { get; set; }

		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double resonance;
		[Export ("resonance")]
		double Resonance { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency resonance:(double)resonance __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:resonance:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency, double resonance);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKMorphingOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKMorphingOscillator")]
	interface MorphingOscillator
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (nonatomic) double index;
		[Export ("index")]
		double Index { get; set; }

		// -(void)rampWithIndex:(double)index;
		[Export ("rampWithIndex:")]
		void RampWithIndex (double index);

		// @property (nonatomic) double detuningOffset;
		[Export ("detuningOffset")]
		double DetuningOffset { get; set; }

		// -(void)rampWithDetuningOffset:(double)detuningOffset;
		[Export ("rampWithDetuningOffset:")]
		void RampWithDetuningOffset (double detuningOffset);

		// @property (nonatomic) double detuningMultiplier;
		[Export ("detuningMultiplier")]
		double DetuningMultiplier { get; set; }

		// -(void)rampWithDetuningMultiplier:(double)detuningMultiplier;
		[Export ("rampWithDetuningMultiplier:")]
		void RampWithDetuningMultiplier (double detuningMultiplier);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKNodeFFTPlot
	[BaseType (typeof(EZAudio.AudioPlot), Name = "AKNodeFFTPlot")]
	interface NodeFftPlot : EZAudio.AudioFftDelegate
	{
		// @property (nonatomic, strong) AKNode * _Nullable node;
		[NullAllowed]
		[Export ("node", ArgumentSemantic.Strong)]
		Node Node { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//		[Export ("initWithCoder:")]
		//		[DesignatedInitializer]
		//		IntPtr Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input frame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("init:frame:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, CGRect frame);

		// -(void)fft:(EZAudioFFT * _Null_unspecified)fft updatedWithFFTData:(float * _Null_unspecified)fftData bufferSize:(vDSP_Length)bufferSize;
		[Internal]
		[Export ("fft:updatedWithFFTData:bufferSize:")]
		unsafe void _FftComputation (EZAudio.AudioFft fft, IntPtr fftData, nuint bufferSize);
	}

	// @interface AKNodeOutputPlot
	[BaseType (typeof(EZAudio.AudioPlot), Name = "AKNodeOutputPlot")]
	interface NodeOutputPlot
	{
		// Father's constructor
		// - (instancetype)initWithFrame:(CGRect)aRect
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect rect);

		// @property (nonatomic, strong) AKNode * _Nullable node;
		[NullAllowed]
		[Export ("node", ArgumentSemantic.Strong)]
		Node Node { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//		[Export ("initWithCoder:")]
		//		[DesignatedInitializer]
		//		IntPtr Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input frame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("init:frame:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, CGRect frame);
	}

	// @interface AKNoiseGenerator : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKNoiseGenerator")]
	interface NoiseGenerator
	{
		// @property (nonatomic) double whitePinkMix;
		[Export ("whitePinkMix")]
		double WhitePinkMix { get; set; }

		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// -(instancetype _Nonnull)initWithWhitePinkMix:(double)whitePinkMix voiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithWhitePinkMix:voiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (double whitePinkMix, nint voiceCount);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKOperationEffect : AKNode
	[BaseType (typeof(Node), Name = "AKOperationEffect")]
	interface OperationEffect
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull parameters;
		[Export ("parameters", ArgumentSemantic.Copy)]
		NSNumber[] Parameters { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input sporth:(NSString * _Nonnull)sporth __attribute__((objc_designated_initializer));
		[Export ("init:sporth:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, string sporth);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKOperationGenerator : AKNode
	[BaseType (typeof(Node), Name = "AKOperationGenerator")]
	interface OperationGenerator
	{
		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull parameters;
		[Export ("parameters", ArgumentSemantic.Copy)]
		NSNumber[] Parameters { get; set; }

		// -(instancetype _Nonnull)init:(NSString * _Nonnull)sporth __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (string sporth);

		// -(void)trigger:(NSArray<NSNumber *> * _Nonnull)parameters;
		[Export ("trigger:")]
		void Trigger (NSNumber[] parameters);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKOscillator")]
	interface Oscillator
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (nonatomic) double detuningOffset;
		[Export ("detuningOffset")]
		double DetuningOffset { get; set; }

		// -(void)rampWithDetuningOffset:(double)detuningOffset;
		[Export ("rampWithDetuningOffset:")]
		void RampWithDetuningOffset (double detuningOffset);

		// @property (nonatomic) double detuningMultiplier;
		[Export ("detuningMultiplier")]
		double DetuningMultiplier { get; set; }

		// -(void)rampWithDetuningMultiplier:(double)detuningMultiplier;
		[Export ("rampWithDetuningMultiplier:")]
		void RampWithDetuningMultiplier (double detuningMultiplier);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKOutputWaveformPlot
	[BaseType (typeof(EZAudio.AudioPlot), Name = "AKOutputWaveformPlot")]
	interface OutputWaveformPlot
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//		[Export ("initWithCoder:")]
		//		[DesignatedInitializer]
		//		IntPtr Constructor (NSCoder aDecoder);

		// +(UIView * _Nonnull)createView:(CGFloat)width height:(CGFloat)height;
		[Static]
		[Export ("createView:height:")]
		UIView CreateView (nfloat width, nfloat height);
	}

	// @interface AKPWMSynth : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKPWMSynth")]
	interface PwmSynth
	{
		// @property (nonatomic) double pulseWidth;
		[Export ("pulseWidth")]
		double PulseWidth { get; set; }

		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// -(instancetype _Nonnull)initWithVoiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint voiceCount);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKPanner : AKNode
	[BaseType (typeof(Node), Name = "AKPanner")]
	interface Panner
	{
		// @property (nonatomic) double pan;
		[Export ("pan")]
		double Pan { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (readonly, nonatomic) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// @property (readonly, nonatomic) BOOL isStopped;
		[Export ("isStopped")]
		bool IsStopped { get; }

		// @property (readonly, nonatomic) BOOL isBypassed;
		[Export ("isBypassed")]
		bool IsBypassed { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input pan:(double)pan __attribute__((objc_designated_initializer));
		[Export ("init:pan:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double pan);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)bypass;
		[Export ("bypass")]
		void Bypass ();
	}

	// @interface AKParametricEQ : AKNode
	[BaseType (typeof(Node), Name = "AKParametricEQ")]
	interface ParametricEq
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double q;
		[Export ("q")]
		double Q { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency q:(double)q gain:(double)gain __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:q:gain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double q, double gain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPeakLimiter : AKNode
	[BaseType (typeof(Node), Name = "AKPeakLimiter")]
	interface PeakLimiter
	{
		// @property (nonatomic) double attackTime;
		[Export ("attackTime")]
		double AttackTime { get; set; }

		// @property (nonatomic) double decayTime;
		[Export ("decayTime")]
		double DecayTime { get; set; }

		// @property (nonatomic) double preGain;
		[Export ("preGain")]
		double PreGain { get; set; }

		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input attackTime:(double)attackTime decayTime:(double)decayTime preGain:(double)preGain __attribute__((objc_designated_initializer));
		[Export ("init:attackTime:decayTime:preGain:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double attackTime, double decayTime, double preGain);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPeakingParametricEqualizerFilter : AKNode
	[BaseType (typeof(Node), Name = "AKPeakingParametricEqualizerFilter")]
	interface PeakingParametricEqualizerFilter
	{
		// @property (nonatomic) double centerFrequency;
		[Export ("centerFrequency")]
		double CenterFrequency { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double q;
		[Export ("q")]
		double Q { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input centerFrequency:(double)centerFrequency gain:(double)gain q:(double)q __attribute__((objc_designated_initializer));
		[Export ("init:centerFrequency:gain:q:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double centerFrequency, double gain, double q);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPhaseLockedVocoder : AKNode
	[BaseType (typeof(Node), Name = "AKPhaseLockedVocoder")]
	interface PhaseLockedVocoder
	{
		// @property (nonatomic) double position;
		[Export ("position")]
		double Position { get; set; }

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// @property (nonatomic) double pitchRatio;
		[Export ("pitchRatio")]
		double PitchRatio { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithAudioFileURL:(NSURL * _Nonnull)audioFileURL position:(double)position amplitude:(double)amplitude pitchRatio:(double)pitchRatio __attribute__((objc_designated_initializer));
		[Export ("initWithAudioFileURL:position:amplitude:pitchRatio:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUrl audioFileURL, double position, double amplitude, double pitchRatio);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPinkNoise : AKVoice
	[BaseType (typeof(Voice), Name = "AKPinkNoise")]
	interface PinkNoise
	{
		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithAmplitude:(double)amplitude __attribute__((objc_designated_initializer));
		[Export ("initWithAmplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (double amplitude);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKPluckedString : AKVoice
	[BaseType (typeof(Voice), Name = "AKPluckedString")]
	interface PluckedString
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithFrequency:(double)frequency amplitude:(double)amplitude lowestFrequency:(double)lowestFrequency __attribute__((objc_designated_initializer));
		[Export ("initWithFrequency:amplitude:lowestFrequency:")]
		[DesignatedInitializer]
		IntPtr Constructor (double frequency, double amplitude, double lowestFrequency);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)triggerWithFrequency:(double)frequency amplitude:(double)amplitude;
		[Export ("triggerWithFrequency:amplitude:")]
		void TriggerWithFrequency (double frequency, double amplitude);

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKReverb : AKNode
	[BaseType (typeof(Node), Name = "AKReverb")]
	interface Reverb
	{
		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input dryWetMix:(double)dryWetMix __attribute__((objc_designated_initializer));
		[Export ("init:dryWetMix:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double dryWetMix);

		// -(void)loadFactoryPreset:(AVAudioUnitReverbPreset)preset;
		[Export ("loadFactoryPreset:")]
		void LoadFactoryPreset (AVAudioUnitReverbPreset preset);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKReverb2 : AKNode
	[BaseType (typeof(Node), Name = "AKReverb2")]
	interface Reverb2
	{
		// @property (nonatomic) double dryWetMix;
		[Export ("dryWetMix")]
		double DryWetMix { get; set; }

		// @property (nonatomic) double gain;
		[Export ("gain")]
		double Gain { get; set; }

		// @property (nonatomic) double minDelayTime;
		[Export ("minDelayTime")]
		double MinDelayTime { get; set; }

		// @property (nonatomic) double maxDelayTime;
		[Export ("maxDelayTime")]
		double MaxDelayTime { get; set; }

		// @property (nonatomic) double decayTimeAt0Hz;
		[Export ("decayTimeAt0Hz")]
		double DecayTimeAt0Hz { get; set; }

		// @property (nonatomic) double decayTimeAtNyquist;
		[Export ("decayTimeAtNyquist")]
		double DecayTimeAtNyquist { get; set; }

		// @property (nonatomic) double randomizeReflections;
		[Export ("randomizeReflections")]
		double RandomizeReflections { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input dryWetMix:(double)dryWetMix gain:(double)gain minDelayTime:(double)minDelayTime maxDelayTime:(double)maxDelayTime decayTimeAt0Hz:(double)decayTimeAt0Hz decayTimeAtNyquist:(double)decayTimeAtNyquist randomizeReflections:(double)randomizeReflections __attribute__((objc_designated_initializer));
		[Export ("init:dryWetMix:gain:minDelayTime:maxDelayTime:decayTimeAt0Hz:decayTimeAtNyquist:randomizeReflections:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double dryWetMix, double gain, double minDelayTime, double maxDelayTime, double decayTimeAt0Hz, double decayTimeAtNyquist, double randomizeReflections);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKRingModulator : AKNode
	[BaseType (typeof(Node), Name = "AKRingModulator")]
	interface RingModulator
	{
		// @property (nonatomic) double frequency1;
		[Export ("frequency1")]
		double Frequency1 { get; set; }

		// @property (nonatomic) double frequency2;
		[Export ("frequency2")]
		double Frequency2 { get; set; }

		// @property (nonatomic) double balance;
		[Export ("balance")]
		double Balance { get; set; }

		// @property (nonatomic) double mix;
		[Export ("mix")]
		double Mix { get; set; }

		// @property (nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input frequency1:(double)frequency1 frequency2:(double)frequency2 balance:(double)balance mix:(double)mix __attribute__((objc_designated_initializer));
		[Export ("init:frequency1:frequency2:balance:mix:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double frequency1, double frequency2, double balance, double mix);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKRolandTB303Filter : AKNode
	[BaseType (typeof(Node), Name = "AKRolandTB303Filter")]
	interface RolandTb303Filter
	{
		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double resonance;
		[Export ("resonance")]
		double Resonance { get; set; }

		// @property (nonatomic) double distortion;
		[Export ("distortion")]
		double Distortion { get; set; }

		// @property (nonatomic) double resonanceAsymmetry;
		[Export ("resonanceAsymmetry")]
		double ResonanceAsymmetry { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input cutoffFrequency:(double)cutoffFrequency resonance:(double)resonance distortion:(double)distortion resonanceAsymmetry:(double)resonanceAsymmetry __attribute__((objc_designated_initializer));
		[Export ("init:cutoffFrequency:resonance:distortion:resonanceAsymmetry:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double cutoffFrequency, double resonance, double distortion, double resonanceAsymmetry);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKRollingOutputPlot
	[BaseType (typeof(EZAudio.AudioPlot), Name = "AKOutputWaveformPlot")]
	interface RollingOutputPlot
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//		[Export ("initWithCoder:")]
		//		[DesignatedInitializer]
		//		IntPtr Constructor (NSCoder aDecoder);

		// +(UIView * _Nonnull)createView:(CGFloat)width height:(CGFloat)height;
		[Static]
		[Export ("createView:height:")]
		UIView CreateView (nfloat width, nfloat height);
	}

	// @interface AKSampler : AKNode
	[BaseType (typeof(Node), Name = "AKSampler")]
	interface Sampler
	{
		// @property (nonatomic, strong) AVAudioUnitSampler * _Nonnull samplerUnit;
		[Export ("samplerUnit", ArgumentSemantic.Strong)]
		AVAudioUnitSampler SamplerUnit { get; set; }

		// -(void)loadWav:(NSString * _Nonnull)file;
		[Export ("loadWav:")]
		void LoadWav (string file);

		// -(void)loadEXS24:(NSString * _Nonnull)file;
		[Export ("loadEXS24:")]
		void LoadExs24 (string file);

		// -(void)loadSoundfont:(NSString * _Nonnull)file;
		[Export ("loadSoundfont:")]
		void LoadSoundfont (string file);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)playNote:(NSInteger)note velocity:(NSInteger)velocity channel:(NSInteger)channel;
		[Export ("playNote:velocity:channel:")]
		void PlayNote (nint note, nint velocity, nint channel);

		// -(void)stopNote:(NSInteger)note channel:(NSInteger)channel;
		[Export ("stopNote:channel:")]
		void StopNote (nint note, nint channel);
	}

	// @interface AKSawtoothOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKSawtoothOscillator")]
	interface SawtoothOscillator
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (nonatomic) double detuningOffset;
		[Export ("detuningOffset")]
		double DetuningOffset { get; set; }

		// -(void)rampWithDetuningOffset:(double)detuningOffset;
		[Export ("rampWithDetuningOffset:")]
		void RampWithDetuningOffset (double detuningOffset);

		// @property (nonatomic) double detuningMultiplier;
		[Export ("detuningMultiplier")]
		double DetuningMultiplier { get; set; }

		// -(void)rampWithDetuningMultiplier:(double)detuningMultiplier;
		[Export ("rampWithDetuningMultiplier:")]
		void RampWithDetuningMultiplier (double detuningMultiplier);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithFrequency:(double)frequency amplitude:(double)amplitude detuningOffset:(double)detuningOffset detuningMultiplier:(double)detuningMultiplier __attribute__((objc_designated_initializer));
		[Export ("initWithFrequency:amplitude:detuningOffset:detuningMultiplier:")]
		[DesignatedInitializer]
		IntPtr Constructor (double frequency, double amplitude, double detuningOffset, double detuningMultiplier);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKSawtoothSynth : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKSawtoothSynth")]
	interface SawtoothSynth
	{
		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// -(instancetype _Nonnull)initWithVoiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint voiceCount);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKSettings : NSObject
	[BaseType (typeof(NSObject), Name = "AKSettings")]
	interface Settings
	{
		// +(double)sampleRate;
		// +(void)setSampleRate:(double)value;
		[Static]
		[Export ("sampleRate")]
		double SampleRate { get; set; }

		// +(uint32_t)numberOfChannels;
		// +(void)setNumberOfChannels:(uint32_t)value;
		[Static]
		[Export ("numberOfChannels")]
		uint NumberOfChannels { get; set; }

		// +(BOOL)audioInputEnabled;
		// +(void)setAudioInputEnabled:(BOOL)value;
		[Static]
		[Export ("audioInputEnabled")]
		bool AudioInputEnabled { get; set; }

		// +(BOOL)playbackWhileMuted;
		// +(void)setPlaybackWhileMuted:(BOOL)value;
		[Static]
		[Export ("playbackWhileMuted")]
		bool PlaybackWhileMuted { get; set; }

		// +(AVAudioFormat * _Nonnull)audioFormat;
		[Static]
		[Export ("audioFormat")]
		AVAudioFormat GetAudioFormat ();
	}

	// @interface AKSquareWaveOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKSquareWaveOscillator")]
	interface SquareWaveOscillator
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (nonatomic) double pulseWidth;
		[Export ("pulseWidth")]
		double PulseWidth { get; set; }

		// -(void)rampWithPulseWidth:(double)pulseWidth;
		[Export ("rampWithPulseWidth:")]
		void RampWithPulseWidth (double pulseWidth);

		// @property (nonatomic) double detuningOffset;
		[Export ("detuningOffset")]
		double DetuningOffset { get; set; }

		// -(void)rampWithDetuningOffset:(double)detuningOffset;
		[Export ("rampWithDetuningOffset:")]
		void RampWithDetuningOffset (double detuningOffset);

		// @property (nonatomic) double detuningMultiplier;
		[Export ("detuningMultiplier")]
		double DetuningMultiplier { get; set; }

		// -(void)rampWithDetuningMultiplier:(double)detuningMultiplier;
		[Export ("rampWithDetuningMultiplier:")]
		void RampWithDetuningMultiplier (double detuningMultiplier);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithFrequency:(double)frequency amplitude:(double)amplitude pulseWidth:(double)pulseWidth detuningOffset:(double)detuningOffset detuningMultiplier:(double)detuningMultiplier __attribute__((objc_designated_initializer));
		[Export ("initWithFrequency:amplitude:pulseWidth:detuningOffset:detuningMultiplier:")]
		[DesignatedInitializer]
		IntPtr Constructor (double frequency, double amplitude, double pulseWidth, double detuningOffset, double detuningMultiplier);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKStringResonator : AKNode
	[BaseType (typeof(Node), Name = "AKStringResonator")]
	interface StringResonator
	{
		// @property (nonatomic) double fundamentalFrequency;
		[Export ("fundamentalFrequency")]
		double FundamentalFrequency { get; set; }

		// @property (nonatomic) double feedback;
		[Export ("feedback")]
		double Feedback { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input fundamentalFrequency:(double)fundamentalFrequency feedback:(double)feedback __attribute__((objc_designated_initializer));
		[Export ("init:fundamentalFrequency:feedback:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double fundamentalFrequency, double feedback);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKSynthKick : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKSynthKick")]
	interface SynthKick
	{
		// -(instancetype _Nonnull)initWithVoiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoiceCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint voiceCount);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	[BaseType (typeof(PolyphonicInstrument), Name = "AKSynthSnare")]
	interface SynthSnare
	{
		// -(instancetype _Nonnull)initWithVoiceCount:(NSInteger)voiceCount duration:(double)duration resonance:(double)resonance __attribute__((objc_designated_initializer));
		[Export ("initWithVoiceCount:duration:resonance:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint voiceCount, double duration, double resonance);

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKTanhDistortion : AKNode
	[BaseType (typeof(Node), Name = "AKTanhDistortion")]
	interface TanhDistortion
	{
		// @property (nonatomic) double pregain;
		[Export ("pregain")]
		double Pregain { get; set; }

		// @property (nonatomic) double postgain;
		[Export ("postgain")]
		double Postgain { get; set; }

		// @property (nonatomic) double postiveShapeParameter;
		[Export ("postiveShapeParameter")]
		double PostiveShapeParameter { get; set; }

		// @property (nonatomic) double negativeShapeParameter;
		[Export ("negativeShapeParameter")]
		double NegativeShapeParameter { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input pregain:(double)pregain postgain:(double)postgain postiveShapeParameter:(double)postiveShapeParameter negativeShapeParameter:(double)negativeShapeParameter __attribute__((objc_designated_initializer));
		[Export ("init:pregain:postgain:postiveShapeParameter:negativeShapeParameter:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double pregain, double postgain, double postiveShapeParameter, double negativeShapeParameter);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKTester : AKNode
	[BaseType (typeof(Node), Name = "AKTester")]
	interface Tester
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull MD5;
		[Export ("MD5")]
		string Md5 { get; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input samples:(NSInteger)samples __attribute__((objc_designated_initializer));
		[Export ("init:samples:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, nint samples);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKThreePoleLowpassFilter : AKNode
	[BaseType (typeof(Node), Name = "AKThreePoleLowpassFilter")]
	interface ThreePoleLowpassFilter
	{
		// @property (nonatomic) double distortion;
		[Export ("distortion")]
		double Distortion { get; set; }

		// @property (nonatomic) double cutoffFrequency;
		[Export ("cutoffFrequency")]
		double CutoffFrequency { get; set; }

		// @property (nonatomic) double resonance;
		[Export ("resonance")]
		double Resonance { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input distortion:(double)distortion cutoffFrequency:(double)cutoffFrequency resonance:(double)resonance __attribute__((objc_designated_initializer));
		[Export ("init:distortion:cutoffFrequency:resonance:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double distortion, double cutoffFrequency, double resonance);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKTimePitch : AKNode
	[BaseType (typeof(Node), Name = "AKTimePitch")]
	interface TimePitch
	{
		// @property (nonatomic) double rate;
		[Export ("rate")]
		double Rate { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (nonatomic) double pitch;
		[Export ("pitch")]
		double Pitch { get; set; }

		// @property (nonatomic) double overlap;
		[Export ("overlap")]
		double Overlap { get; set; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input rate:(double)rate pitch:(double)pitch overlap:(double)overlap __attribute__((objc_designated_initializer));
		[Export ("init:rate:pitch:overlap:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double rate, double pitch, double overlap);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKToneComplementFilter : AKNode
	[BaseType (typeof(Node), Name = "AKToneComplementFilter")]
	interface ToneComplementFilter
	{
		// @property (nonatomic) double halfPowerPoint;
		[Export ("halfPowerPoint")]
		double HalfPowerPoint { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input halfPowerPoint:(double)halfPowerPoint __attribute__((objc_designated_initializer));
		[Export ("init:halfPowerPoint:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double halfPowerPoint);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKToneFilter : AKNode
	[BaseType (typeof(Node), Name = "AKToneFilter")]
	interface ToneFilter
	{
		// @property (nonatomic) double halfPowerPoint;
		[Export ("halfPowerPoint")]
		double HalfPowerPoint { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input halfPowerPoint:(double)halfPowerPoint __attribute__((objc_designated_initializer));
		[Export ("init:halfPowerPoint:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double halfPowerPoint);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKTriangleOscillator : AKVoice
	[BaseType (typeof(Voice), Name = "AKTriangleOscillator")]
	interface TriangleOscillator
	{
		// @property (nonatomic) double frequency;
		[Export ("frequency")]
		double Frequency { get; set; }

		// -(void)rampWithFrequency:(double)frequency;
		[Export ("rampWithFrequency:")]
		void RampWithFrequency (double frequency);

		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (nonatomic) double detuningOffset;
		[Export ("detuningOffset")]
		double DetuningOffset { get; set; }

		// -(void)rampWithDetuningOffset:(double)detuningOffset;
		[Export ("rampWithDetuningOffset:")]
		void RampWithDetuningOffset (double detuningOffset);

		// @property (nonatomic) double detuningMultiplier;
		[Export ("detuningMultiplier")]
		double DetuningMultiplier { get; set; }

		// -(void)rampWithDetuningMultiplier:(double)detuningMultiplier;
		[Export ("rampWithDetuningMultiplier:")]
		void RampWithDetuningMultiplier (double detuningMultiplier);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithFrequency:(double)frequency amplitude:(double)amplitude detuningOffset:(double)detuningOffset detuningMultiplier:(double)detuningMultiplier __attribute__((objc_designated_initializer));
		[Export ("initWithFrequency:amplitude:detuningOffset:detuningMultiplier:")]
		[DesignatedInitializer]
		IntPtr Constructor (double frequency, double amplitude, double detuningOffset, double detuningMultiplier);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKVariableDelay : AKNode
	[BaseType (typeof(Node), Name = "AKVariableDelay")]
	interface VariableDelay
	{
		// @property (nonatomic) double time;
		[Export ("time")]
		double Time { get; set; }

		// @property (nonatomic) double feedback;
		[Export ("feedback")]
		double Feedback { get; set; }

		// @property (readonly, nonatomic) BOOL isStarted;
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)init:(AKNode * _Nonnull)input time:(double)time feedback:(double)feedback maximumDelayTime:(double)maximumDelayTime __attribute__((objc_designated_initializer));
		[Export ("init:time:feedback:maximumDelayTime:")]
		[DesignatedInitializer]
		IntPtr Constructor (Node input, double time, double feedback, double maximumDelayTime);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface AKWavetableSynth : AKPolyphonicInstrument
	[BaseType (typeof(PolyphonicInstrument), Name = "AKWavetableSynth")]
	interface WavetableSynth
	{
		// Father's constructor
		// -(instancetype _Nonnull)initWithVoice:(AKVoice * _Nonnull)voice voiceCount:(NSInteger)voiceCount __attribute__((objc_designated_initializer));
		[Export ("initWithVoice:voiceCount:")]
		IntPtr Constructor (Voice voice, nint voiceCount);

		// @property (nonatomic) double attackDuration;
		[Export ("attackDuration")]
		double AttackDuration { get; set; }

		// @property (nonatomic) double decayDuration;
		[Export ("decayDuration")]
		double DecayDuration { get; set; }

		// @property (nonatomic) double sustainLevel;
		[Export ("sustainLevel")]
		double SustainLevel { get; set; }

		// @property (nonatomic) double releaseDuration;
		[Export ("releaseDuration")]
		double ReleaseDuration { get; set; }

		// -(void)playVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note velocity:(NSInteger)velocity;
		[New]
		[Export ("playVoice:note:velocity:")]
		void PlayVoice (Voice voice, nint note, nint velocity);

		// -(void)stopVoice:(AKVoice * _Nonnull)voice note:(NSInteger)note;
		[New]
		[Export ("stopVoice:note:")]
		void StopVoice (Voice voice, nint note);
	}

	// @interface AKWhiteNoise : AKVoice
	[BaseType (typeof(Voice), Name = "AKWhiteNoise")]
	interface WhiteNoise
	{
		// @property (nonatomic) double amplitude;
		[Export ("amplitude")]
		double Amplitude { get; set; }

		// -(void)rampWithAmplitude:(double)amplitude;
		[Export ("rampWithAmplitude:")]
		void RampWithAmplitude (double amplitude);

		// @property (readonly, nonatomic) BOOL isStarted;
		[New]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// -(instancetype _Nonnull)initWithAmplitude:(double)amplitude __attribute__((objc_designated_initializer));
		[Export ("initWithAmplitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (double amplitude);

		// -(AKVoice * _Nonnull)duplicate;
		[New]
		[Export ("duplicate")]
		Voice Duplicate { get; }

		// -(void)start;
		[New]
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[New]
		[Export ("stop")]
		void Stop ();
	}

	// @interface AudioKit : NSObject
	[BaseType (typeof(NSObject), Name = "AudioKit")]
	interface AudioKitManager
	{
		// +(AVAudioFormat * _Nonnull)format;
		[Static]
		[Export ("format")]
		AVAudioFormat GetFormat { get; }

		// +(AVAudioEngine * _Nonnull)engine;
		[Static]
		[Export ("engine")]
		AVAudioEngine GetEngine { get; }

		// +(AKNode * _Nullable)output;
		// +(void)setOutput:(AKNode * _Nullable)newValue;
		[Static]
		[NullAllowed]
		[Export ("output")]
		Node GetOutput { get; set; }

		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// +(void)stop;
		[Static]
		[Export ("stop")]
		void Stop ();

		// +(AKTester * _Nullable)tester;
		// +(void)setTester:(AKTester * _Nullable)value;
		[Static]
		[Export ("tester")]
		[NullAllowed]
		Tester Tester { get; set; }

		// +(void)testOutput:(AKNode * _Nonnull)node samples:(NSInteger)samples;
		[Static]
		[Export ("testOutput:samples:")]
		void TestOutput (Node node, nint samples);
	}
}

namespace Xamarin.EZAudio
{
	// @interface EZAudio : NSObject
	[BaseType (typeof(NSObject), Name = "EZAudio")]
	interface EZAudioApi
	{
		// extern double EZAudioVersionNumber;
		[Field ("EZAudioVersionNumber", "__Internal")]
		double VersionNumber { get; }
	}

	// void (^)(EZAudioDevice *, BOOL *))block
	delegate void AudioDeviceEnumerateHandler (AudioDevice device,out bool stop);

	// @interface EZAudioDevice : NSObject
	[BaseType (typeof(NSObject), Name = "EZAudioDevice")]
	interface AudioDevice
	{
		// +(EZAudioDevice *)currentInputDevice;
		[Static]
		[Export ("currentInputDevice")]
		AudioDevice CurrentInputDevice { get; }

		// +(EZAudioDevice *)currentOutputDevice;
		[Static]
		[Export ("currentOutputDevice")]
		AudioDevice CurrentOutputDevice { get; }

		// +(NSArray *)inputDevices;
		[Static]
		[Export ("inputDevices")]
		AudioDevice[] InputDevices { get; }

		// +(NSArray *)outputDevices;
		[Static]
		[Export ("outputDevices")]
		AudioDevice[] OutputDevices { get; }

		// +(void)enumerateInputDevicesUsingBlock:(void (^)(EZAudioDevice *, BOOL *))block;
		[Static]
		[Export ("enumerateInputDevicesUsingBlock:")]
		unsafe void EnumerateInputDevicesUsingBlock (AudioDeviceEnumerateHandler handler);

		// +(void)enumerateOutputDevicesUsingBlock:(void (^)(EZAudioDevice *, BOOL *))block;
		[Static]
		[Export ("enumerateOutputDevicesUsingBlock:")]
		unsafe void EnumerateOutputDevicesUsingBlock (AudioDeviceEnumerateHandler handler);

		// @property (readonly, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong) AVAudioSessionPortDescription * port;
		[Export ("port", ArgumentSemantic.Strong)]
		AVAudioSessionPortDescription Port { get; }

		// @property (readonly, nonatomic, strong) AVAudioSessionDataSourceDescription * dataSource;
		[Export ("dataSource", ArgumentSemantic.Strong)]
		AVAudioSessionDataSourceDescription DataSource { get; }
	}

	interface IAudioDisplayLinkDelegate
	{
	}

	// @protocol EZAudioDisplayLinkDelegate <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZAudioDisplayLinkDelegate")]
	interface AudioDisplayLinkDelegate
	{
		// @required -(void)displayLinkNeedsDisplay:(EZAudioDisplayLink *)displayLink;
		[Abstract]
		[EventArgs ("AudioDisplayLinkNeedsDisplay")]
		[Export ("displayLinkNeedsDisplay:")]
		void NeedsDisplay (AudioDisplayLink displayLink);
	}

	// @interface EZAudioDisplayLink : NSObject
	[BaseType (typeof(NSObject),
		Name = "EZAudioDisplayLink",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(AudioDisplayLinkDelegate) })]
	interface AudioDisplayLink
	{
		// +(instancetype)displayLinkWithDelegate:(id<EZAudioDisplayLinkDelegate>)delegate;
		[Static]
		[Export ("displayLinkWithDelegate:")]
		AudioDisplayLink GetInstance (IAudioDisplayLinkDelegate aDelegate);

		// @property (nonatomic, weak) id<EZAudioDisplayLinkDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IAudioDisplayLinkDelegate Delegate { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	interface IAudioFftDelegate
	{
	}

	// @protocol EZAudioFFTDelegate <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZAudioFFTDelegate")]
	interface AudioFftDelegate
	{
		// @optional -(void)fft:(EZAudioFFT *)fft updatedWithFFTData:(float *)fftData bufferSize:(vDSP_Length)bufferSize;
		[EventArgs ("AudioFftUpdated")]
		[EventName ("Updated")]
		[Export ("fft:updatedWithFFTData:bufferSize:")]
		unsafe void DidUpdate (AudioFft fft, IntPtr fftData, ulong bufferSize);
	}

	// @interface EZAudioFFT : NSObject
	[BaseType (typeof(NSObject),
		Name = "EZAudioFFT",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(AudioFftDelegate) })]
	interface AudioFft
	{
		// -(instancetype)initWithMaximumBufferSize:(vDSP_Length)maximumBufferSize sampleRate:(float)sampleRate;
		[Export ("initWithMaximumBufferSize:sampleRate:")]
		IntPtr Constructor (ulong maximumBufferSize, float sampleRate);

		// -(instancetype)initWithMaximumBufferSize:(vDSP_Length)maximumBufferSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Export ("initWithMaximumBufferSize:sampleRate:delegate:")]
		IntPtr Constructor (ulong maximumBufferSize, float sampleRate, IAudioFftDelegate aDelegate);

		// +(instancetype)fftWithMaximumBufferSize:(vDSP_Length)maximumBufferSize sampleRate:(float)sampleRate;
		[Static]
		[Export ("fftWithMaximumBufferSize:sampleRate:")]
		AudioFft GetInstance (ulong maximumBufferSize, float sampleRate);

		// +(instancetype)fftWithMaximumBufferSize:(vDSP_Length)maximumBufferSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Static]
		[Export ("fftWithMaximumBufferSize:sampleRate:delegate:")]
		AudioFft FftWithMaximumBufferSize (ulong maximumBufferSize, float sampleRate, IAudioFftDelegate aDelegate);

		// @property (nonatomic, weak) id<EZAudioFFTDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IAudioFftDelegate Delegate { get; set; }

		// @property (readonly, nonatomic) COMPLEX_SPLIT complexSplit;
		[Export ("complexSplit")]
		SplitComplex ComplexSplit { get; }

		// @property (readonly, nonatomic) float * fftData;
		[Export ("fftData")]
		IntPtr FftData { get; }

		// @property (readonly, nonatomic) FFTSetup fftSetup;
		[Export ("fftSetup")]
		IntPtr FftSetup { get; }

		// @property (readonly, nonatomic) float * inversedFFTData;
		[Export ("inversedFFTData")]
		IntPtr InversedFftData { get; }

		// @property (readonly, nonatomic) float maxFrequency;
		[Export ("maxFrequency")]
		float MaxFrequency { get; }

		// @property (readonly, nonatomic) vDSP_Length maxFrequencyIndex;
		[Export ("maxFrequencyIndex")]
		ulong MaxFrequencyIndex { get; }

		// @property (readonly, nonatomic) float maxFrequencyMagnitude;
		[Export ("maxFrequencyMagnitude")]
		float MaxFrequencyMagnitude { get; }

		// @property (readonly, nonatomic) vDSP_Length maximumBufferSize;
		[Export ("maximumBufferSize")]
		ulong MaximumBufferSize { get; }

		// @property (readwrite, nonatomic) float sampleRate;
		[Export ("sampleRate")]
		float SampleRate { get; set; }

		// -(float *)computeFFTWithBuffer:(float *)buffer withBufferSize:(UInt32)bufferSize;
		[Internal]
		[Export ("computeFFTWithBuffer:withBufferSize:")]
		IntPtr _ComputeFft (IntPtr buffer, uint bufferSize);

		// -(float)frequencyAtIndex:(vDSP_Length)index;
		[Export ("frequencyAtIndex:")]
		float GetFrequency (ulong index);

		// -(float)frequencyMagnitudeAtIndex:(vDSP_Length)index;
		[Export ("frequencyMagnitudeAtIndex:")]
		float GetFrequencyMagnitude (ulong index);
	}

	// @interface EZAudioFFTRolling : EZAudioFFT
	[BaseType (typeof(AudioFft), Name = "EZAudioFFTRolling")]
	interface AudioFftRolling
	{
		// -(instancetype)initWithWindowSize:(vDSP_Length)windowSize sampleRate:(float)sampleRate;
		[Export ("initWithWindowSize:sampleRate:")]
		IntPtr Constructor (ulong windowSize, float sampleRate);

		// -(instancetype)initWithWindowSize:(vDSP_Length)windowSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Export ("initWithWindowSize:sampleRate:delegate:")]
		IntPtr Constructor (ulong windowSize, float sampleRate, IAudioFftDelegate aDelegate);

		// -(instancetype)initWithWindowSize:(vDSP_Length)windowSize historyBufferSize:(vDSP_Length)historyBufferSize sampleRate:(float)sampleRate;
		[Export ("initWithWindowSize:historyBufferSize:sampleRate:")]
		IntPtr Constructor (ulong windowSize, ulong historyBufferSize, float sampleRate);

		// -(instancetype)initWithWindowSize:(vDSP_Length)windowSize historyBufferSize:(vDSP_Length)historyBufferSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Export ("initWithWindowSize:historyBufferSize:sampleRate:delegate:")]
		IntPtr Constructor (ulong windowSize, ulong historyBufferSize, float sampleRate, IAudioFftDelegate @delegate);

		// +(instancetype)fftWithWindowSize:(vDSP_Length)windowSize sampleRate:(float)sampleRate;
		[New]
		[Static]
		[Export ("fftWithWindowSize:sampleRate:")]
		AudioFftRolling GetInstance (ulong windowSize, float sampleRate);

		// +(instancetype)fftWithWindowSize:(vDSP_Length)windowSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Static]
		[Export ("fftWithWindowSize:sampleRate:delegate:")]
		AudioFftRolling GetInstance (ulong windowSize, float sampleRate, IAudioFftDelegate aDelegate);

		// +(instancetype)fftWithWindowSize:(vDSP_Length)windowSize historyBufferSize:(vDSP_Length)historyBufferSize sampleRate:(float)sampleRate;
		[Static]
		[Export ("fftWithWindowSize:historyBufferSize:sampleRate:")]
		AudioFftRolling GetInstance (ulong windowSize, ulong historyBufferSize, float sampleRate);

		// +(instancetype)fftWithWindowSize:(vDSP_Length)windowSize historyBufferSize:(vDSP_Length)historyBufferSize sampleRate:(float)sampleRate delegate:(id<EZAudioFFTDelegate>)delegate;
		[Static]
		[Export ("fftWithWindowSize:historyBufferSize:sampleRate:delegate:")]
		AudioFftRolling GetInstance (ulong windowSize, ulong historyBufferSize, float sampleRate, IAudioFftDelegate aDelegate);

		// @property (readonly, nonatomic) vDSP_Length windowSize;
		[Export ("windowSize")]
		ulong WindowSize { get; }

		// @property (readonly, nonatomic) float * timeDomainData;
		[Internal]
		[Export ("timeDomainData")]
		IntPtr _TimeDomainData { get; }

		// @property (readonly, nonatomic) UInt32 timeDomainBufferSize;
		[Internal]
		[Export ("timeDomainBufferSize")]
		uint _TimeDomainBufferSize { get; }
	}

	interface IAudioFileDelegate
	{
	}

	// @protocol EZAudioFileDelegate <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZAudioFileDelegate")]
	interface AudioFileDelegate
	{
		// @optional -(void)audioFile:(EZAudioFile *)audioFile readAudio:(float **)buffer withBufferSize:(UInt32)bufferSize withNumberOfChannels:(UInt32)numberOfChannels;
		[EventArgs ("AudioFileAudioRead")]
		[EventName ("AudioRead")]
		[Export ("audioFile:readAudio:withBufferSize:withNumberOfChannels:")]
		unsafe void DidReadAudio (AudioFile audioFile, IntPtr buffer, uint bufferSize, uint numberOfChannels);

		// @optional -(void)audioFileUpdatedPosition:(EZAudioFile *)audioFile;
		[EventArgs ("AudioFilePositionUpdated")]
		[EventName ("AudioFilePositionUpdated")]
		[Export ("audioFileUpdatedPosition:")]
		void DidUpdatePosition (AudioFile audioFile);
	}

	delegate void AudioWaveformDataCompletionHandler (IntPtr waveformData,int lenght);

	// @interface EZAudioFile : NSObject <NSCopying>
	[BaseType (typeof(NSObject),
		Name = "EZAudioFile",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(AudioFileDelegate) })]
	interface AudioFile : INSCopying
	{
		// @property (nonatomic, weak) id<EZAudioFileDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IAudioFileDelegate Delegate { get; set; }

		// -(instancetype)initWithURL:(NSURL *)url;
		[Export ("initWithURL:")]
		IntPtr Constructor (NSUrl url);

		// -(instancetype)initWithURL:(NSURL *)url delegate:(id<EZAudioFileDelegate>)delegate;
		[Export ("initWithURL:delegate:")]
		IntPtr Constructor (NSUrl url, IAudioFileDelegate aDelegate);

		// -(instancetype)initWithURL:(NSURL *)url delegate:(id<EZAudioFileDelegate>)delegate clientFormat:(AudioStreamBasicDescription)clientFormat;
		[Export ("initWithURL:delegate:clientFormat:")]
		IntPtr Constructor (NSUrl url, IAudioFileDelegate aDelegate, AudioStreamBasicDescription clientFormat);

		// +(instancetype)audioFileWithURL:(NSURL *)url;
		[Static]
		[Export ("audioFileWithURL:")]
		AudioFile AudioFileWithURL (NSUrl url);

		// +(instancetype)audioFileWithURL:(NSURL *)url delegate:(id<EZAudioFileDelegate>)delegate;
		[Static]
		[Export ("audioFileWithURL:delegate:")]
		AudioFile AudioFileWithURL (NSUrl url, IAudioFileDelegate aDelegate);

		// +(instancetype)audioFileWithURL:(NSURL *)url delegate:(id<EZAudioFileDelegate>)delegate clientFormat:(AudioStreamBasicDescription)clientFormat;
		[Static]
		[Export ("audioFileWithURL:delegate:clientFormat:")]
		AudioFile AudioFileWithURL (NSUrl url, IAudioFileDelegate aDelegate, AudioStreamBasicDescription clientFormat);

		// +(AudioStreamBasicDescription)defaultClientFormat;
		[Static]
		[Export ("defaultClientFormat")]
		AudioStreamBasicDescription DefaultClientFormat { get; }

		// +(Float64)defaultClientFormatSampleRate;
		[Static]
		[Export ("defaultClientFormatSampleRate")]
		double DefaultClientFormatSampleRate { get; }

		// +(NSArray *)supportedAudioFileTypes;
		[Static]
		[Export ("supportedAudioFileTypes")]
		string[] SupportedAudioFileTypes { get; }

		// -(void)readFrames:(UInt32)frames audioBufferList:(AudioBufferList *)audioBufferList bufferSize:(UInt32 *)bufferSize eof:(BOOL *)eof;
		// [Verify]
		[Internal]
		[Export ("readFrames:audioBufferList:bufferSize:eof:")]
		unsafe void _ReadFrames (uint frames, IntPtr audioBufferList, out uint bufferSize, out bool eof);

		// -(void)seekToFrame:(SInt64)frame;
		[Export ("seekToFrame:")]
		void SeekToFrame (long frame);

		// @property (readwrite) AudioStreamBasicDescription clientFormat;
		[Export ("clientFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription ClientFormat { get; set; }

		// @property (readwrite, nonatomic) NSTimeInterval currentTime;
		[Export ("currentTime")]
		double CurrentTime { get; set; }

		// @property (readonly) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// @property (readonly) AudioStreamBasicDescription fileFormat;
		[Export ("fileFormat")]
		AudioStreamBasicDescription FileFormat { get; }

		// @property (readonly) NSString * formattedCurrentTime;
		[Export ("formattedCurrentTime")]
		string FormattedCurrentTime { get; }

		// @property (readonly) NSString * formattedDuration;
		[Export ("formattedDuration")]
		string FormattedDuration { get; }

		// @property (readonly) SInt64 frameIndex;
		[Export ("frameIndex")]
		long FrameIndex { get; }

		// @property (readonly) NSDictionary * metadata;
		[Export ("metadata")]
		NSDictionary Metadata { get; }

		// @property (readonly) NSTimeInterval totalDuration __attribute__((deprecated("")));
		[Obsolete]
		[Export ("totalDuration")]
		double TotalDuration { get; }

		// @property (readonly) SInt64 totalClientFrames;
		[Export ("totalClientFrames")]
		long TotalClientFrames { get; }

		// @property (readonly) SInt64 totalFrames;
		[Export ("totalFrames")]
		long TotalFrames { get; }

		// @property (readonly, copy, nonatomic) NSURL * url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// -(EZAudioFloatData *)getWaveformData;
		[Export ("getWaveformData")]
		AudioFloatData GetWaveformData ();

		// -(EZAudioFloatData *)getWaveformDataWithNumberOfPoints:(UInt32)numberOfPoints;
		[Export ("getWaveformDataWithNumberOfPoints:")]
		AudioFloatData GetWaveformData (uint numberOfPoints);

		// -(void)getWaveformDataWithCompletionBlock:(EZAudioWaveformDataCompletionBlock)completion;
		[Export ("getWaveformDataWithCompletionBlock:")]
		void GetWaveformData (AudioWaveformDataCompletionHandler completion);

		// -(void)getWaveformDataWithNumberOfPoints:(UInt32)numberOfPoints completion:(EZAudioWaveformDataCompletionBlock)completion;
		[Export ("getWaveformDataWithNumberOfPoints:completion:")]
		void GetWaveformData (uint numberOfPoints, AudioWaveformDataCompletionHandler completion);
	}

	// @interface EZAudioFloatConverter : NSObject
	[BaseType (typeof(NSObject), Name = "EZAudioFloatConverter")]
	interface AudioFloatConverter
	{
		// extern const UInt32 EZAudioFloatConverterDefaultPacketSize;
		[Internal]
		[Field ("EZAudioFloatConverterDefaultPacketSize", "__Internal")]
		IntPtr _DefaultPacketSize { get; }

		// +(instancetype)converterWithInputFormat:(AudioStreamBasicDescription)inputFormat;
		[Static]
		[Export ("converterWithInputFormat:")]
		AudioFloatConverter GetInstance (AudioStreamBasicDescription inputFormat);

		// @property (readonly, assign, nonatomic) AudioStreamBasicDescription inputFormat;
		[Export ("inputFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription InputFormat { get; }

		// @property (readonly, assign, nonatomic) AudioStreamBasicDescription floatFormat;
		[Export ("floatFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription FloatFormat { get; }

		// -(instancetype)initWithInputFormat:(AudioStreamBasicDescription)inputFormat;
		[Export ("initWithInputFormat:")]
		IntPtr Constructor (AudioStreamBasicDescription inputFormat);

		// -(void)convertDataFromAudioBufferList:(AudioBufferList *)audioBufferList withNumberOfFrames:(UInt32)frames toFloatBuffers:(float **)buffers;
		[Internal]
		[Export ("convertDataFromAudioBufferList:withNumberOfFrames:toFloatBuffers:")]
		unsafe void _ConvertData (IntPtr audioBufferList, uint frames, IntPtr buffers);

		// -(void)convertDataFromAudioBufferList:(AudioBufferList *)audioBufferList withNumberOfFrames:(UInt32)frames toFloatBuffers:(float **)buffers packetDescriptions:(AudioStreamPacketDescription *)packetDescriptions;
		[Internal]
		[Export ("convertDataFromAudioBufferList:withNumberOfFrames:toFloatBuffers:packetDescriptions:")]
		unsafe void _ConvertData (IntPtr audioBufferList, uint frames, IntPtr buffers, out AudioStreamPacketDescription packetDescriptions);
	}

	// @interface EZAudioFloatData : NSObject
	[DisableDefaultCtor]
	[BaseType (typeof(NSObject), Name = "EZAudioFloatData")]
	interface AudioFloatData
	{
		// +(instancetype)dataWithNumberOfChannels:(int)numberOfChannels buffers:(float **)buffers bufferSize:(UInt32)bufferSize;
		[Internal]
		[Static]
		[Export ("dataWithNumberOfChannels:buffers:bufferSize:")]
		unsafe AudioFloatData _GetInstance (int numberOfChannels, IntPtr buffers, uint bufferSize);

		// @property (readonly, assign, nonatomic) int numberOfChannels;
		[Export ("numberOfChannels")]
		int NumberOfChannels { get; }

		// @property (readonly, assign, nonatomic) float ** buffers;
		[Internal]
		[Export ("buffers", ArgumentSemantic.Assign)]
		unsafe IntPtr _Buffers { get; }

		// @property (readonly, assign, nonatomic) UInt32 bufferSize;
		[Export ("bufferSize")]
		uint BufferSize { get; }

		// -(float *)bufferForChannel:(int)channel;
		[Internal]
		[Export ("bufferForChannel:")]
		unsafe IntPtr _BufferForChannel (int channel);
	}

	interface IAudioPlayerDelegate
	{
	}

	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZAudioPlayerDelegate")]
	interface AudioPlayerDelegate
	{
		// @optional -(void)audioPlayer:(EZAudioPlayer *)audioPlayer playedAudio:(float **)buffer withBufferSize:(UInt32)bufferSize withNumberOfChannels:(UInt32)numberOfChannels inAudioFile:(EZAudioFile *)audioFile;
		[EventArgs ("AudioPlayerAudioPlayed")]
		[EventName ("AudioPlayed")]
		[Export ("audioPlayer:playedAudio:withBufferSize:withNumberOfChannels:inAudioFile:")]
		unsafe void DidPlayAudio (AudioPlayer audioPlayer, IntPtr buffer, uint bufferSize, uint numberOfChannels, AudioFile audioFile);

		// @optional -(void)audioPlayer:(EZAudioPlayer *)audioPlayer updatedPosition:(SInt64)framePosition inAudioFile:(EZAudioFile *)audioFile;
		[EventArgs ("AudioPlayerPositionUpdated")]
		[EventName ("PositionUpdated")]
		[Export ("audioPlayer:updatedPosition:inAudioFile:")]
		void DidUpdatePosition (AudioPlayer audioPlayer, long framePosition, AudioFile audioFile);

		// @optional -(void)audioPlayer:(EZAudioPlayer *)audioPlayer reachedEndOfAudioFile:(EZAudioFile *)audioFile;
		[EventArgs ("AudioPlayerEndOfAudioFileReached")]
		[EventName ("EndOfAudioFileReached")]
		[Export ("audioPlayer:reachedEndOfAudioFile:")]
		void DidReachEndOfAudioFile (AudioPlayer audioPlayer, AudioFile audioFile);
	}

	// @interface EZAudioPlayer : NSObject <EZAudioFileDelegate, EZOutputDataSource, EZOutputDelegate>
	[BaseType (typeof(NSObject),
		Name = "EZAudioPlayer",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(AudioPlayerDelegate) })]
	interface AudioPlayer : AudioFileDelegate, OutputDataSource, OutputDelegate
	{
		// extern NSString *const EZAudioPlayerDidChangeAudioFileNotification;
		// [Verify]
		[Field ("EZAudioPlayerDidChangeAudioFileNotification", "__Internal")]
		NSString DidChangeAudioFileNotification { get; }

		// extern NSString *const EZAudioPlayerDidChangeOutputDeviceNotification;
		[Field ("EZAudioPlayerDidChangeOutputDeviceNotification", "__Internal")]
		NSString DidChangeOutputDeviceNotification { get; }

		// extern NSString *const EZAudioPlayerDidChangePanNotification;
		[Field ("EZAudioPlayerDidChangePanNotification", "__Internal")]
		NSString DidChangePanNotification { get; }

		// extern NSString *const EZAudioPlayerDidChangePlayStateNotification;
		[Field ("EZAudioPlayerDidChangePlayStateNotification", "__Internal")]
		NSString DidChangePlayStateNotification { get; }

		// extern NSString *const EZAudioPlayerDidChangeVolumeNotification;
		[Field ("EZAudioPlayerDidChangeVolumeNotification", "__Internal")]
		NSString DidChangeVolumeNotification { get; }

		// extern NSString *const EZAudioPlayerDidReachEndOfFileNotification;
		[Field ("EZAudioPlayerDidReachEndOfFileNotification", "__Internal")]
		NSString DidReachEndOfFileNotification { get; }

		// extern NSString *const EZAudioPlayerDidSeekNotification;
		[Field ("EZAudioPlayerDidSeekNotification", "__Internal")]
		NSString DidSeekNotification { get; }

		// @property (nonatomic, weak) id<EZAudioPlayerDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IAudioPlayerDelegate Delegate { get; set; }

		// @property (assign, nonatomic) BOOL shouldLoop;
		[Export ("shouldLoop")]
		bool ShouldLoop { get; set; }

		// -(instancetype)initWithAudioFile:(EZAudioFile *)audioFile;
		[Export ("initWithAudioFile:")]
		IntPtr Constructor (AudioFile audioFile);

		// -(instancetype)initWithAudioFile:(EZAudioFile *)audioFile delegate:(id<EZAudioPlayerDelegate>)delegate;
		[Export ("initWithAudioFile:delegate:")]
		IntPtr Constructor (AudioFile audioFile, IAudioPlayerDelegate aDelegate);

		// -(instancetype)initWithDelegate:(id<EZAudioPlayerDelegate>)delegate;
		[Export ("initWithDelegate:")]
		IntPtr Constructor (IAudioPlayerDelegate aDelegate);

		// -(instancetype)initWithURL:(NSURL *)url;
		[Export ("initWithURL:")]
		IntPtr Constructor (NSUrl url);

		// -(instancetype)initWithURL:(NSURL *)url delegate:(id<EZAudioPlayerDelegate>)delegate;
		[Export ("initWithURL:delegate:")]
		IntPtr Constructor (NSUrl url, IAudioPlayerDelegate aDelegate);

		// +(instancetype)audioPlayer;
		[Static]
		[Export ("audioPlayer")]
		AudioPlayer GetAudioPlayer ();

		// +(instancetype)audioPlayerWithAudioFile:(EZAudioFile *)audioFile;
		[Static]
		[Export ("audioPlayerWithAudioFile:")]
		AudioPlayer AudioPlayerWithAudioFile (AudioFile audioFile);

		// +(instancetype)audioPlayerWithAudioFile:(EZAudioFile *)audioFile delegate:(id<EZAudioPlayerDelegate>)delegate;
		[Static]
		[Export ("audioPlayerWithAudioFile:delegate:")]
		AudioPlayer AudioPlayerWithAudioFile (AudioFile audioFile, IAudioPlayerDelegate aDelegate);

		// +(instancetype)audioPlayerWithDelegate:(id<EZAudioPlayerDelegate>)delegate;
		[Static]
		[Export ("audioPlayerWithDelegate:")]
		AudioPlayer AudioPlayerWithDelegate (IAudioPlayerDelegate aDelegate);

		// +(instancetype)audioPlayerWithURL:(NSURL *)url;
		[Static]
		[Export ("audioPlayerWithURL:")]
		AudioPlayer AudioPlayerWithURL (NSUrl url);

		// +(instancetype)audioPlayerWithURL:(NSURL *)url delegate:(id<EZAudioPlayerDelegate>)delegate;
		[Static]
		[Export ("audioPlayerWithURL:delegate:")]
		AudioPlayer AudioPlayerWithURL (NSUrl url, IAudioPlayerDelegate aDelegate);

		// +(instancetype)sharedAudioPlayer;
		[Static]
		[Export ("sharedAudioPlayer")]
		AudioPlayer SharedAudioPlayer ();

		// @property (readwrite, copy, nonatomic) EZAudioFile * audioFile;
		[Export ("audioFile", ArgumentSemantic.Copy)]
		AudioFile AudioFile { get; set; }

		// @property (readwrite, nonatomic) NSTimeInterval currentTime;
		[Export ("currentTime")]
		double CurrentTime { get; set; }

		// @property (readwrite) EZAudioDevice * device;
		[Export ("device", ArgumentSemantic.Assign)]
		AudioDevice Device { get; set; }

		// @property (readonly) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// @property (readonly) NSString * formattedCurrentTime;
		[Export ("formattedCurrentTime")]
		string FormattedCurrentTime { get; }

		// @property (readonly) NSString * formattedDuration;
		[Export ("formattedDuration")]
		string FormattedDuration { get; }

		// @property (readwrite, nonatomic, strong) EZOutput * output;
		[Export ("output", ArgumentSemantic.Strong)]
		Output Output { get; set; }

		// @property (readonly) SInt64 frameIndex;
		[Export ("frameIndex")]
		long FrameIndex { get; }

		// @property (readonly) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// @property (assign, nonatomic) float pan;
		[Export ("pan")]
		float Pan { get; set; }

		// @property (readonly) SInt64 totalFrames;
		[Export ("totalFrames")]
		long TotalFrames { get; }

		// @property (readonly, copy, nonatomic) NSURL * url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// @property (assign, nonatomic) float volume;
		[Export ("volume")]
		float Volume { get; set; }

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)playAudioFile:(EZAudioFile *)audioFile;
		[Export ("playAudioFile:")]
		void PlayAudioFile (AudioFile audioFile);

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)seekToFrame:(SInt64)frame;
		[Export ("seekToFrame:")]
		void SeekToFrame (long frame);
	}

	[BaseType (typeof(CAShapeLayer), Name = "EZAudioPlotWaveformLayer")]
	interface AudioPlotWaveformLayer
	{
	}

	// @interface EZAudioPlot : EZPlot
	[BaseType (typeof(Plot), Name = "EZAudioPlot")]
	interface AudioPlot
	{
		// Father's constructor
		// - (instancetype)initWithFrame:(CGRect)aRect
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect rect);

		// extern const UInt32 EZAudioPlotDefaultHistoryBufferLength;
		[Internal]
		[Field ("EZAudioPlotDefaultHistoryBufferLength", "__Internal")]
		IntPtr _DefaultHistoryBufferLength { get; }

		// extern const UInt32 EZAudioPlotDefaultMaxHistoryBufferLength;
		[Internal]
		[Field ("EZAudioPlotDefaultMaxHistoryBufferLength", "__Internal")]
		IntPtr _DefaultMaxHistoryBufferLength { get; }

		// @property (assign, nonatomic) BOOL shouldOptimizeForRealtimePlot;
		[Export ("shouldOptimizeForRealtimePlot")]
		bool ShouldOptimizeForRealtimePlot { get; set; }

		// @property (assign, nonatomic) BOOL shouldCenterYAxis;
		[Export ("shouldCenterYAxis")]
		bool ShouldCenterYAxis { get; set; }

		// @property (nonatomic, strong) EZAudioPlotWaveformLayer * waveformLayer;
		[Export ("waveformLayer", ArgumentSemantic.Strong)]
		AudioPlotWaveformLayer WaveformLayer { get; set; }

		// -(int)rollingHistoryLength;
		// -(int)setRollingHistoryLength:(int)historyLength;
		[Export ("rollingHistoryLength")]
		int RollingHistoryLength { get; set; }

		// -(CGPathRef)createPathWithPoints:(CGPoint *)points pointCount:(UInt32)pointCount inRect:(EZRect)rect;
		[Internal]
		[Export ("createPathWithPoints:pointCount:inRect:")]
		CGPath _CreatePath (IntPtr points, uint pointCount, CGRect rect);

		// -(int)defaultRollingHistoryLength;
		[Export ("defaultRollingHistoryLength")]
		int DefaultRollingHistoryLength { get; }

		// -(void)setupPlot;
		[Export ("setupPlot")]
		void SetupPlot ();

		// -(int)initialPointCount;
		[Export ("initialPointCount")]
		int InitialPointCount { get; }

		// -(int)maximumRollingHistoryLength;
		[Export ("maximumRollingHistoryLength")]
		int MaximumRollingHistoryLength { get; }

		// -(void)redraw;
		[Export ("redraw")]
		void Redraw ();

		// -(void)setSampleData:(float *)data length:(int)length;
		[Internal]
		[Export ("setSampleData:length:")]
		unsafe void _SetSampleData (IntPtr data, int length);

		// @property (nonatomic, strong) EZAudioDisplayLink * displayLink;
		[Export ("displayLink", ArgumentSemantic.Strong)]
		AudioDisplayLink DisplayLink { get; set; }

		// @property (assign, nonatomic) EZPlotHistoryInfo * historyInfo;
		//		[Export ("historyInfo", ArgumentSemantic.Assign)]
		//		// [Verify]
		//		unsafe EZPlotHistoryInfo* HistoryInfo { get; set; }

		// @property (assign, nonatomic) CGPoint * points;
		[Internal]
		[Export ("points", ArgumentSemantic.Assign)]
		unsafe IntPtr _Points { get; set; }

		// @property (assign, nonatomic) UInt32 pointCount;
		[Internal]
		[Export ("pointCount")]
		uint _PointCount { get; set; }
	}

	// @interface EZAudioPlotGL : GLKView
	[BaseType (typeof(GLKView), Name = "EZAudioPlotGL")]
	interface AudioPlotGl
	{
		// -(instancetype)initWithFrame:
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(instancetype)initWithFrame:context:
		[Export ("initWithFrame:context:")]
		IntPtr Constructor (CGRect frame, EAGLContext context);

		// @property (nonatomic, strong) UIColor * backgroundColor;
		[New]
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) float gain;
		[Export ("gain")]
		float Gain { get; set; }

		// @property (assign, nonatomic) EZPlotType plotType;
		[Export ("plotType", ArgumentSemantic.Assign)]
		PlotType PlotType { get; set; }

		// @property (assign, nonatomic) BOOL shouldFill;
		[Export ("shouldFill")]
		bool ShouldFill { get; set; }

		// @property (assign, nonatomic) BOOL shouldMirror;
		[Export ("shouldMirror")]
		bool ShouldMirror { get; set; }

		// -(void)updateBuffer:(float *)buffer withBufferSize:(UInt32)bufferSize;
		[Internal]
		[Export ("updateBuffer:withBufferSize:")]
		unsafe void _UpdateBuffer (IntPtr buffer, uint bufferSize);

		// -(int)rollingHistoryLength;
		// -(int)setRollingHistoryLength:(int)historyLength;
		[Export ("rollingHistoryLength")]
		int RollingHistoryLength { get; set; }

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// -(void)pauseDrawing;
		[Export ("pauseDrawing")]
		void PauseDrawing ();

		// -(void)resumeDrawing;
		[Export ("resumeDrawing")]
		void ResumeDrawing ();

		// -(void)redrawWithPoints:(EZAudioPlotGLPoint *)points pointCount:(UInt32)pointCount baseEffect:(GLKBaseEffect *)baseEffect vertexBufferObject:(GLuint)vbo vertexArrayBuffer:(GLuint)vab interpolated:(BOOL)interpolated mirrored:(BOOL)mirrored gain:(float)gain;
		[Internal]
		[Export ("redrawWithPoints:pointCount:baseEffect:vertexBufferObject:vertexArrayBuffer:interpolated:mirrored:gain:")]
		unsafe void _Redraw (IntPtr points, uint pointCount, GLKBaseEffect baseEffect, uint vbo, uint vab, bool interpolated, bool mirrored, float gain);

		// -(void)redraw;
		[Export ("redraw")]
		void Redraw ();

		// -(void)setup;
		[Export ("setup")]
		void Setup ();

		// -(void)setSampleData:(float *)data length:(int)length;
		[Internal]
		[Export ("setSampleData:length:")]
		unsafe void _SetSampleData (IntPtr data, int length);

		// -(int)defaultRollingHistoryLength;
		[Export ("defaultRollingHistoryLength")]
		int DefaultRollingHistoryLength { get; }

		// -(int)maximumRollingHistoryLength;
		[Export ("maximumRollingHistoryLength")]
		int MaximumRollingHistoryLength { get; }
	}

	// @interface EZAudioUtilities : NSObject
	[BaseType (typeof(NSObject), Name = "EZAudioUtilities")]
	interface AudioUtilities
	{
		// +(BOOL)shouldExitOnCheckResultFail;
		// +(void)setShouldExitOnCheckResultFail:(BOOL)shouldExitOnCheckResultFail;
		[Static]
		[Export ("shouldExitOnCheckResultFail")]
		bool ShouldExitOnCheckResultFail { get; set; }

		// +(AudioBufferList *)audioBufferListWithNumberOfFrames:(UInt32)frames numberOfChannels:(UInt32)channels interleaved:(BOOL)interleaved;
		[Internal]
		[Static]
		[Export ("audioBufferListWithNumberOfFrames:numberOfChannels:interleaved:")]
		unsafe IntPtr _GetAudioBufferList (uint frames, uint channels, bool interleaved);

		// +(float **)floatBuffersWithNumberOfFrames:(UInt32)frames numberOfChannels:(UInt32)channels;
		[Internal]
		[Static]
		[Export ("floatBuffersWithNumberOfFrames:numberOfChannels:")]
		unsafe IntPtr _GetFloatBuffers (uint frames, uint channels);

		// +(void)freeBufferList:(AudioBufferList *)bufferList;
		// [Verify]
		[Internal]
		[Static]
		[Export ("freeBufferList:")]
		unsafe void _FreeBufferList (IntPtr bufferList);

		// +(AudioStreamBasicDescription)AIFFFormatWithNumberOfChannels:(UInt32)channels sampleRate:(float)sampleRate;
		[Static]
		[Export ("AIFFFormatWithNumberOfChannels:sampleRate:")]
		AudioStreamBasicDescription GetAiffFormat (uint channels, float sampleRate);

		// +(AudioStreamBasicDescription)iLBCFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("iLBCFormatWithSampleRate:")]
		AudioStreamBasicDescription GetIlbcFormat (float sampleRate);

		// +(AudioStreamBasicDescription)floatFormatWithNumberOfChannels:(UInt32)channels sampleRate:(float)sampleRate;
		[Static]
		[Export ("floatFormatWithNumberOfChannels:sampleRate:")]
		AudioStreamBasicDescription GetFloatFormat (uint channels, float sampleRate);

		// +(AudioStreamBasicDescription)M4AFormatWithNumberOfChannels:(UInt32)channels sampleRate:(float)sampleRate;
		[Static]
		[Export ("M4AFormatWithNumberOfChannels:sampleRate:")]
		AudioStreamBasicDescription GetM4aFormat (uint channels, float sampleRate);

		// +(AudioStreamBasicDescription)monoFloatFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("monoFloatFormatWithSampleRate:")]
		AudioStreamBasicDescription GetMonoFloatFormat (float sampleRate);

		// +(AudioStreamBasicDescription)monoCanonicalFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("monoCanonicalFormatWithSampleRate:")]
		AudioStreamBasicDescription GetMonoCanonicalFormat (float sampleRate);

		// +(AudioStreamBasicDescription)stereoCanonicalNonInterleavedFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("stereoCanonicalNonInterleavedFormatWithSampleRate:")]
		AudioStreamBasicDescription GetStereoCanonicalNonInterleavedFormat (float sampleRate);

		// +(AudioStreamBasicDescription)stereoFloatInterleavedFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("stereoFloatInterleavedFormatWithSampleRate:")]
		AudioStreamBasicDescription GetStereoFloatInterleavedFormat (float sampleRate);

		// +(AudioStreamBasicDescription)stereoFloatNonInterleavedFormatWithSampleRate:(float)sampleRate;
		[Static]
		[Export ("stereoFloatNonInterleavedFormatWithSampleRate:")]
		AudioStreamBasicDescription GetStereoFloatNonInterleavedFormat (float sampleRate);

		// +(BOOL)isFloatFormat:(AudioStreamBasicDescription)asbd;
		[Static]
		[Export ("isFloatFormat:")]
		bool IsFloatFormat (AudioStreamBasicDescription asbd);

		// +(BOOL)isInterleaved:(AudioStreamBasicDescription)asbd;
		[Static]
		[Export ("isInterleaved:")]
		bool IsInterleaved (AudioStreamBasicDescription asbd);

		// +(BOOL)isLinearPCM:(AudioStreamBasicDescription)asbd;
		[Static]
		[Export ("isLinearPCM:")]
		bool IsLinearPCM (AudioStreamBasicDescription asbd);

		// +(void)printASBD:(AudioStreamBasicDescription)asbd;
		[Static]
		[Export ("printASBD:")]
		void PrintASBD (AudioStreamBasicDescription asbd);

		// +(NSString *)displayTimeStringFromSeconds:(NSTimeInterval)seconds;
		[Static]
		[Export ("displayTimeStringFromSeconds:")]
		string DisplayTimeString (double seconds);

		// +(NSString *)stringForAudioStreamBasicDescription:(AudioStreamBasicDescription)asbd;
		[Static]
		[Export ("stringForAudioStreamBasicDescription:")]
		string GetString (AudioStreamBasicDescription asbd);

		// +(void)setCanonicalAudioStreamBasicDescription:(AudioStreamBasicDescription *)asbd numberOfChannels:(UInt32)nChannels interleaved:(BOOL)interleaved;
		[Static]
		[Export ("setCanonicalAudioStreamBasicDescription:numberOfChannels:interleaved:")]
		void SetCanonicalAudioStreamBasicDescription (ref AudioStreamBasicDescription asbd, uint nChannels, bool interleaved);

		// +(void)appendBufferAndShift:(float *)buffer withBufferSize:(int)bufferLength toScrollHistory:(float *)scrollHistory withScrollHistorySize:(int)scrollHistoryLength;
		[Internal]
		[Static]
		[Export ("appendBufferAndShift:withBufferSize:toScrollHistory:withScrollHistorySize:")]
		unsafe void _AppendBufferAndShift (IntPtr buffer, int bufferLength, IntPtr scrollHistory, int scrollHistoryLength);

		// +(void)appendValue:(float)value toScrollHistory:(float *)scrollHistory withScrollHistorySize:(int)scrollHistoryLength;
		[Internal]
		[Static]
		[Export ("appendValue:toScrollHistory:withScrollHistorySize:")]
		unsafe void _AppendValue (float value, IntPtr scrollHistory, int scrollHistoryLength);

		// +(float)MAP:(float)value leftMin:(float)leftMin leftMax:(float)leftMax rightMin:(float)rightMin rightMax:(float)rightMax;
		[Static]
		[Export ("MAP:leftMin:leftMax:rightMin:rightMax:")]
		float Map (float value, float leftMin, float leftMax, float rightMin, float rightMax);

		// +(float)RMS:(float *)buffer length:(int)bufferSize;
		[Internal]
		[Static]
		[Export ("RMS:length:")]
		unsafe float _Rms (IntPtr buffer, int bufferSize);

		// +(float)SGN:(float)value;
		[Static]
		[Export ("SGN:")]
		float Sgn (float value);

		// +(NSString *)noteNameStringForFrequency:(float)frequency includeOctave:(BOOL)includeOctave;
		[Static]
		[Export ("noteNameStringForFrequency:includeOctave:")]
		string GetNoteName (float frequency, bool includeOctave);

		// +(void)checkResult:(OSStatus)result operation:(const char *)operation;
		[Static]
		[Export ("checkResult:operation:")]
		unsafe void CheckResult (int result, [PlainString] string operation);

		// +(NSString *)stringFromUInt32Code:(UInt32)code;
		[Static]
		[Export ("stringFromUInt32Code:")]
		string GetString (uint code);

		// +(void)getColorComponentsFromCGColor:(CGColorRef)color red:(CGFloat *)red green:(CGFloat *)green blue:(CGFloat *)blue alpha:(CGFloat *)alpha;
		[Static]
		[Export ("getColorComponentsFromCGColor:red:green:blue:alpha:")]
		unsafe void GetColorComponents (CGColor color, out nfloat red, out nfloat green, out nfloat blue, out nfloat alpha);

		// +(void)updateScrollHistory:(float **)scrollHistory withLength:(int)scrollHistoryLength atIndex:(int *)index withBuffer:(float *)buffer withBufferSize:(int)bufferSize isResolutionChanging:(BOOL *)isChanging;
		[Internal]
		[Static]
		[Export ("updateScrollHistory:withLength:atIndex:withBuffer:withBufferSize:isResolutionChanging:")]
		unsafe void _UpdateScrollHistory (IntPtr scrollHistory, int scrollHistoryLength, out int index, IntPtr buffer, int bufferSize, out bool isChanging);

		// TODO:
		//		// +(void)appendDataToCircularBuffer:(TPCircularBuffer *)circularBuffer fromAudioBufferList:(AudioBufferList *)audioBufferList;
		//		// [Verify]
		//		[Static]
		//		[Export ("appendDataToCircularBuffer:fromAudioBufferList:")]
		//		unsafe void AppendDataToCircularBuffer (TPCircularBuffer* circularBuffer, AudioBufferList* audioBufferList);
		//
		//		// +(void)circularBuffer:(TPCircularBuffer *)circularBuffer withSize:(int)size;
		//		// [Verify]
		//		[Static]
		//		[Export ("circularBuffer:withSize:")]
		//		unsafe void CircularBuffer (TPCircularBuffer* circularBuffer, int size);
		//
		//		// +(void)freeCircularBuffer:(TPCircularBuffer *)circularBuffer;
		//		// [Verify]
		//		[Static]
		//		[Export ("freeCircularBuffer:")]
		//		unsafe void FreeCircularBuffer (TPCircularBuffer* circularBuffer);
		//
		//		// +(void)appendBufferRMS:(float *)buffer withBufferSize:(UInt32)bufferSize toHistoryInfo:(EZPlotHistoryInfo *)historyInfo;
		//		// [Verify]
		//		[Static]
		//		[Export ("appendBufferRMS:withBufferSize:toHistoryInfo:")]
		//		unsafe void AppendBufferRMS (float* buffer, uint bufferSize, EZPlotHistoryInfo* historyInfo);
		//
		//		// +(void)appendBuffer:(float *)buffer withBufferSize:(UInt32)bufferSize toHistoryInfo:(EZPlotHistoryInfo *)historyInfo;
		//		// [Verify]
		//		[Static]
		//		[Export ("appendBuffer:withBufferSize:toHistoryInfo:")]
		//		unsafe void AppendBuffer (float* buffer, uint bufferSize, EZPlotHistoryInfo* historyInfo);
		//
		//		// +(void)clearHistoryInfo:(EZPlotHistoryInfo *)historyInfo;
		//		// [Verify]
		//		[Static]
		//		[Export ("clearHistoryInfo:")]
		//		unsafe void ClearHistoryInfo (EZPlotHistoryInfo* historyInfo);
		//
		//		// +(void)freeHistoryInfo:(EZPlotHistoryInfo *)historyInfo;
		//		// [Verify]
		//		[Static]
		//		[Export ("freeHistoryInfo:")]
		//		unsafe void FreeHistoryInfo (EZPlotHistoryInfo* historyInfo);
		//
		//		// +(EZPlotHistoryInfo *)historyInfoWithDefaultLength:(int)defaultLength maximumLength:(int)maximumLength;
		//		// [Verify]
		//		[Static]
		//		[Export ("historyInfoWithDefaultLength:maximumLength:")]
		//		unsafe EZPlotHistoryInfo* HistoryInfoWithDefaultLength (int defaultLength, int maximumLength);
	}

	interface IMicrophoneDelegate
	{
	}

	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZMicrophoneDelegate")]
	interface MicrophoneDelegate
	{
		// @optional -(void)microphone:(EZMicrophone *)microphone changedPlayingState:(BOOL)isPlaying;
		[EventArgs ("MicrophonePlayingStateChanged")]
		[EventName ("PlayingStateChanged")]
		[Export ("microphone:changedPlayingState:")]
		void DidChangePlayingState (Microphone microphone, bool isPlaying);

		// @optional -(void)microphone:(EZMicrophone *)microphone changedDevice:(EZAudioDevice *)device;
		[EventArgs ("MicrophoneDeviceChanged")]
		[EventName ("DeviceChanged")]
		[Export ("microphone:changedDevice:")]
		void DidChangeDevice (Microphone microphone, AudioDevice device);

		// @optional -(void)microphone:(EZMicrophone *)microphone hasAudioStreamBasicDescription:(AudioStreamBasicDescription)audioStreamBasicDescription;
		[EventArgs ("MicrophoneHasAudioStreamBasicDescription")]
		[Export ("microphone:hasAudioStreamBasicDescription:")]
		void HasAudioStreamBasicDescription (Microphone microphone, AudioStreamBasicDescription audioStreamBasicDescription);

		// @optional -(void)microphone:(EZMicrophone *)microphone hasAudioReceived:(float **)buffer withBufferSize:(UInt32)bufferSize withNumberOfChannels:(UInt32)numberOfChannels;
		[EventArgs ("MicrophoneHasAudioReceived")]
		[Export ("microphone:hasAudioReceived:withBufferSize:withNumberOfChannels:")]
		unsafe void HasAudioReceived (Microphone microphone, IntPtr buffer, uint bufferSize, uint numberOfChannels);

		// @optional -(void)microphone:(EZMicrophone *)microphone hasBufferList:(AudioBufferList *)bufferList withBufferSize:(UInt32)bufferSize withNumberOfChannels:(UInt32)numberOfChannels;
		// [Verify]
		[EventArgs ("MicrophoneHasBufferList")]
		[Export ("microphone:hasBufferList:withBufferSize:withNumberOfChannels:")]
		unsafe void HasBufferList (Microphone microphone, IntPtr bufferList, uint bufferSize, uint numberOfChannels);
	}

	// @interface EZMicrophone : NSObject <EZOutputDataSource>
	[BaseType (typeof(NSObject),
		Name = "EZMicrophone",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(MicrophoneDelegate) })]
	interface Microphone : OutputDataSource
	{
		// @property (nonatomic, weak) id<EZMicrophoneDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IMicrophoneDelegate Delegate { get; set; }

		// @property (nonatomic, strong) EZAudioDevice * device;
		[Export ("device", ArgumentSemantic.Strong)]
		AudioDevice Device { get; set; }

		// @property (assign, nonatomic) BOOL microphoneOn;
		[Export ("microphoneOn")]
		bool MicrophoneOn { get; set; }

		// @property (nonatomic, strong) EZOutput * output;
		[Export ("output", ArgumentSemantic.Strong)]
		Output Output { get; set; }

		// -(EZMicrophone *)initWithMicrophoneDelegate:(id<EZMicrophoneDelegate>)delegate;
		[Export ("initWithMicrophoneDelegate:")]
		IntPtr Constructor (IMicrophoneDelegate aDelegate);

		// -(EZMicrophone *)initWithMicrophoneDelegate:(id<EZMicrophoneDelegate>)delegate withAudioStreamBasicDescription:(AudioStreamBasicDescription)audioStreamBasicDescription;
		[Export ("initWithMicrophoneDelegate:withAudioStreamBasicDescription:")]
		IntPtr Constructor (IMicrophoneDelegate aDelegate, AudioStreamBasicDescription audioStreamBasicDescription);

		// -(EZMicrophone *)initWithMicrophoneDelegate:(id<EZMicrophoneDelegate>)delegate startsImmediately:(BOOL)startsImmediately;
		[Export ("initWithMicrophoneDelegate:startsImmediately:")]
		IntPtr Constructor (IMicrophoneDelegate aDelegate, bool startsImmediately);

		// -(EZMicrophone *)initWithMicrophoneDelegate:(id<EZMicrophoneDelegate>)delegate withAudioStreamBasicDescription:(AudioStreamBasicDescription)audioStreamBasicDescription startsImmediately:(BOOL)startsImmediately;
		[Export ("initWithMicrophoneDelegate:withAudioStreamBasicDescription:startsImmediately:")]
		IntPtr Constructor (IMicrophoneDelegate aDelegate, AudioStreamBasicDescription audioStreamBasicDescription, bool startsImmediately);

		// +(EZMicrophone *)microphoneWithDelegate:(id<EZMicrophoneDelegate>)delegate;
		[Static]
		[Export ("microphoneWithDelegate:")]
		Microphone GetInstance (IMicrophoneDelegate aDelegate);

		// +(EZMicrophone *)microphoneWithDelegate:(id<EZMicrophoneDelegate>)delegate withAudioStreamBasicDescription:(AudioStreamBasicDescription)audioStreamBasicDescription;
		[Static]
		[Export ("microphoneWithDelegate:withAudioStreamBasicDescription:")]
		Microphone GetInstance (IMicrophoneDelegate aDelegate, AudioStreamBasicDescription audioStreamBasicDescription);

		// +(EZMicrophone *)microphoneWithDelegate:(id<EZMicrophoneDelegate>)delegate startsImmediately:(BOOL)startsImmediately;
		[Static]
		[Export ("microphoneWithDelegate:startsImmediately:")]
		Microphone GetInstance (IMicrophoneDelegate aDelegate, bool startsImmediately);

		// +(EZMicrophone *)microphoneWithDelegate:(id<EZMicrophoneDelegate>)delegate withAudioStreamBasicDescription:(AudioStreamBasicDescription)audioStreamBasicDescription startsImmediately:(BOOL)startsImmediately;
		[Static]
		[Export ("microphoneWithDelegate:withAudioStreamBasicDescription:startsImmediately:")]
		Microphone GetInstance (IMicrophoneDelegate aDelegate, AudioStreamBasicDescription audioStreamBasicDescription, bool startsImmediately);

		// +(EZMicrophone *)sharedMicrophone;
		[Static]
		[Export ("sharedMicrophone")]
		Microphone SharedInstance { get; }

		// -(void)startFetchingAudio;
		[Export ("startFetchingAudio")]
		void StartFetchingAudio ();

		// -(void)stopFetchingAudio;
		[Export ("stopFetchingAudio")]
		void StopFetchingAudio ();

		// -(AudioStreamBasicDescription)audioStreamBasicDescription;
		// -(void)setAudioStreamBasicDescription:(AudioStreamBasicDescription)asbd;
		[Export ("audioStreamBasicDescription")]
		AudioStreamBasicDescription AudioStreamBasicDescription { get; set; }

		// -(AudioUnit *)audioUnit;
		[Internal]
		[Export ("audioUnit")]
		IntPtr _AudioUnit { get; }

		// - (void)setDevice:(EZAudioDevice *)device;
		[Export ("setDevice:")]
		void SetDevice (AudioDevice device);

		// - (void)setOutput:(EZOutput *)output;
		[Export ("setOutput:")]
		void SetOutput (Output device);

		// -(AudioStreamBasicDescription)defaultStreamFormat;
		[Export ("defaultStreamFormat")]
		AudioStreamBasicDescription DefaultStreamFormat { get; }

		// -(UInt32)numberOfChannels;
		[Export ("numberOfChannels")]
		uint NumberOfChannels { get; }
	}

	interface IOutputDataSource
	{
	}

	// @protocol EZOutputDataSource <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZOutputDataSource")]
	interface OutputDataSource
	{
		// @required -(OSStatus)output:(EZOutput *)output shouldFillAudioBufferList:(AudioBufferList *)audioBufferList withNumberOfFrames:(UInt32)frames timestamp:(const AudioTimeStamp *)timestamp;
		// [Verify]
		[Abstract]
		[Export ("output:shouldFillAudioBufferList:withNumberOfFrames:timestamp:")]
		unsafe int ShouldFillAudioBufferList (Output output, IntPtr audioBufferList, uint frames, ref AudioTimeStamp timestamp);
	}

	interface IOutputDelegate
	{
	}

	// @protocol EZOutputDelegate <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZOutputDelegate")]
	interface OutputDelegate
	{
		// @optional -(void)output:(EZOutput *)output changedPlayingState:(BOOL)isPlaying;
		[Export ("output:changedPlayingState:")]
		void ChangedPlayingState (Output output, bool isPlaying);

		// @optional -(void)output:(EZOutput *)output changedDevice:(EZAudioDevice *)device;
		[Export ("output:changedDevice:")]
		void ChangedDevice (Output output, AudioDevice device);

		// @optional -(void)output:(EZOutput *)output playedAudio:(float **)buffer withBufferSize:(UInt32)bufferSize withNumberOfChannels:(UInt32)numberOfChannels;
		[Export ("output:playedAudio:withBufferSize:withNumberOfChannels:")]
		void PlayedAudio (Output output, IntPtr buffer, uint bufferSize, uint numberOfChannels);
	}

	// @interface EZOutput : NSObject
	[BaseType (typeof(NSObject), Name = "EZOutput")]
	interface Output
	{
		// extern const UInt32 EZOutputMaximumFramesPerSlice;
		[Internal]
		[Field ("EZOutputMaximumFramesPerSlice", "__Internal")]
		IntPtr _MaximumFramesPerSlice { get; }

		// extern const Float64 EZOutputDefaultSampleRate;
		[Field ("EZOutputDefaultSampleRate", "__Internal")]
		double DefaultSampleRate { get; }

		// -(instancetype)initWithDataSource:(id<EZOutputDataSource>)dataSource;
		[Export ("initWithDataSource:")]
		IntPtr Constructor (IOutputDataSource dataSource);

		// -(instancetype)initWithDataSource:(id<EZOutputDataSource>)dataSource inputFormat:(AudioStreamBasicDescription)inputFormat;
		[Export ("initWithDataSource:inputFormat:")]
		IntPtr Constructor (IOutputDataSource dataSource, AudioStreamBasicDescription inputFormat);

		// +(instancetype)output;
		[Static]
		[Export ("output")]
		Output GetInstance ();

		// +(instancetype)outputWithDataSource:(id<EZOutputDataSource>)dataSource;
		[Static]
		[Export ("outputWithDataSource:")]
		Output GetInstance (IOutputDataSource dataSource);

		// +(instancetype)outputWithDataSource:(id<EZOutputDataSource>)dataSource inputFormat:(AudioStreamBasicDescription)inputFormat;
		[Static]
		[Export ("outputWithDataSource:inputFormat:")]
		Output GetInstance (IOutputDataSource dataSource, AudioStreamBasicDescription inputFormat);

		// +(instancetype)sharedOutput;
		[Static]
		[Export ("sharedOutput")]
		Output SharedInstance { get; }

		// @property (readwrite, nonatomic) AudioStreamBasicDescription inputFormat;
		[Export ("inputFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription InputFormat { get; set; }

		// @property (readwrite, nonatomic) AudioStreamBasicDescription clientFormat;
		[Export ("clientFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription ClientFormat { get; set; }

		// @property (nonatomic, weak) id<EZOutputDataSource> _Nullable dataSource;
		[NullAllowed]
		[Export ("dataSource", ArgumentSemantic.Weak)]
		IOutputDataSource DataSource { get; set; }

		// @property (nonatomic, weak) id<EZOutputDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IOutputDelegate Delegate { get; set; }

		// @property (readonly) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// @property (assign, nonatomic) float pan;
		[Export ("pan")]
		float Pan { get; set; }

		// @property (assign, nonatomic) float volume;
		[Export ("volume")]
		float Volume { get; set; }

		// @property (readonly) AUGraph graph;
		[Internal]
		[Export ("graph")]
		IntPtr _Graph { get; }

		// @property (readonly) AudioUnit converterAudioUnit;
		[Internal]
		[Export ("converterAudioUnit")]
		IntPtr _ConverterAudioUnit { get; }

		// @property (readonly) AudioUnit mixerAudioUnit;
		[Internal]
		[Export ("mixerAudioUnit")]
		IntPtr _MixerAudioUnit { get; }

		// @property (readonly) AudioUnit outputAudioUnit;
		[Internal]
		[Export ("outputAudioUnit")]
		IntPtr _OutputAudioUnit { get; }

		// @property (readwrite, nonatomic, strong) EZAudioDevice * device;
		[Export ("device", ArgumentSemantic.Strong)]
		AudioDevice Device { get; set; }

		// -(void)startPlayback;
		[Export ("startPlayback")]
		void StartPlayback ();

		// -(void)stopPlayback;
		[Export ("stopPlayback")]
		void StopPlayback ();

		// -(OSStatus)connectOutputOfSourceNode:(AUNode)sourceNode sourceNodeOutputBus:(UInt32)sourceNodeOutputBus toDestinationNode:(AUNode)destinationNode destinationNodeInputBus:(UInt32)destinationNodeInputBus inGraph:(AUGraph)graph;
		[Internal]
		[Export ("connectOutputOfSourceNode:sourceNodeOutputBus:toDestinationNode:destinationNodeInputBus:inGraph:")]
		int _ConnectOutputOfSourceNode (int sourceNode, uint sourceNodeOutputBus, int destinationNode, uint destinationNodeInputBus, IntPtr graph);

		// -(AudioStreamBasicDescription)defaultClientFormat;
		[Export ("defaultClientFormat")]
		AudioStreamBasicDescription DefaultClientFormat { get; }

		// -(AudioStreamBasicDescription)defaultInputFormat;
		[Export ("defaultInputFormat")]
		AudioStreamBasicDescription DefaultInputFormat { get; }

		// -(OSType)outputAudioUnitSubType;
		[Export ("outputAudioUnitSubType")]
		uint OutputAudioUnitSubType { get; }
	}

	// @interface EZPlot : UIView
	[BaseType (typeof(UIView), Name = "EZPlot")]
	interface Plot
	{
		// Father's constructor
		// - (instancetype)initWithFrame:(CGRect)aRect
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect rect);

		// @property (nonatomic, strong) UIColor * backgroundColor;
		[New]
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) float gain;
		[Export ("gain")]
		float Gain { get; set; }

		// @property (assign, nonatomic) EZPlotType plotType;
		[Export ("plotType", ArgumentSemantic.Assign)]
		PlotType PlotType { get; set; }

		// @property (assign, nonatomic) BOOL shouldFill;
		[Export ("shouldFill")]
		bool ShouldFill { get; set; }

		// @property (assign, nonatomic) BOOL shouldMirror;
		[Export ("shouldMirror")]
		bool ShouldMirror { get; set; }
	}

	interface IRecorderDelegate
	{
	}

	// @protocol EZRecorderDelegate <NSObject>
	[Model]
	[Protocol]
	[BaseType (typeof(NSObject), Name = "EZRecorderDelegate")]
	interface RecorderDelegate
	{
		// @optional -(void)recorderDidClose:(EZRecorder *)recorder;
		[EventArgs ("Recorder")]
		[EventName ("Closed")]
		[Export ("recorderDidClose:")]
		void DidClose (Recorder recorder);

		// @optional -(void)recorderUpdatedCurrentTime:(EZRecorder *)recorder;
		[EventArgs ("Recorder")]
		[EventName ("CurrentTimeUpdate")]
		[Export ("recorderUpdatedCurrentTime:")]
		void DidUpdateCurrentTime (Recorder recorder);
	}

	// @interface EZRecorder : NSObject
	[BaseType (typeof(NSObject),
		Name = "EZRecorder",
		Delegates = new string[] { "Delegate" },
		Events = new Type[] { typeof(RecorderDelegate) })]
	interface Recorder
	{
		// @property (nonatomic, weak) id<EZRecorderDelegate> _Nullable delegate;
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		IRecorderDelegate Delegate { get; set; }

		// -(instancetype)initWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileType:(EZRecorderFileType)fileType;
		[Export ("initWithURL:clientFormat:fileType:")]
		IntPtr Constructor (NSUrl url, AudioStreamBasicDescription clientFormat, RecorderFileType fileType);

		// -(instancetype)initWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileType:(EZRecorderFileType)fileType delegate:(id<EZRecorderDelegate>)delegate;
		[Export ("initWithURL:clientFormat:fileType:delegate:")]
		IntPtr Constructor (NSUrl url, AudioStreamBasicDescription clientFormat, RecorderFileType fileType, IRecorderDelegate aDelegate);

		// -(instancetype)initWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileFormat:(AudioStreamBasicDescription)fileFormat audioFileTypeID:(AudioFileTypeID)audioFileTypeID;
		[Export ("initWithURL:clientFormat:fileFormat:audioFileTypeID:")]
		IntPtr Constructor (NSUrl url, AudioStreamBasicDescription clientFormat, AudioStreamBasicDescription fileFormat, uint audioFileTypeID);

		// -(instancetype)initWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileFormat:(AudioStreamBasicDescription)fileFormat audioFileTypeID:(AudioFileTypeID)audioFileTypeID delegate:(id<EZRecorderDelegate>)delegate;
		[Export ("initWithURL:clientFormat:fileFormat:audioFileTypeID:delegate:")]
		IntPtr Constructor (NSUrl url, AudioStreamBasicDescription clientFormat, AudioStreamBasicDescription fileFormat, uint audioFileTypeID, RecorderDelegate @delegate);

		// +(instancetype)recorderWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileType:(EZRecorderFileType)fileType;
		[Static]
		[Export ("recorderWithURL:clientFormat:fileType:")]
		Recorder GetInstance (NSUrl url, AudioStreamBasicDescription clientFormat, RecorderFileType fileType);

		// +(instancetype)recorderWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileType:(EZRecorderFileType)fileType delegate:(id<EZRecorderDelegate>)delegate;
		[Static]
		[Export ("recorderWithURL:clientFormat:fileType:delegate:")]
		Recorder GetInstance (NSUrl url, AudioStreamBasicDescription clientFormat, RecorderFileType fileType, IRecorderDelegate aDelegate);

		// +(instancetype)recorderWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileFormat:(AudioStreamBasicDescription)fileFormat audioFileTypeID:(AudioFileTypeID)audioFileTypeID;
		[Static]
		[Export ("recorderWithURL:clientFormat:fileFormat:audioFileTypeID:")]
		Recorder GetInstance (NSUrl url, AudioStreamBasicDescription clientFormat, AudioStreamBasicDescription fileFormat, uint audioFileTypeID);

		// +(instancetype)recorderWithURL:(NSURL *)url clientFormat:(AudioStreamBasicDescription)clientFormat fileFormat:(AudioStreamBasicDescription)fileFormat audioFileTypeID:(AudioFileTypeID)audioFileTypeID delegate:(id<EZRecorderDelegate>)delegate;
		[Static]
		[Export ("recorderWithURL:clientFormat:fileFormat:audioFileTypeID:delegate:")]
		Recorder GetInstance (NSUrl url, AudioStreamBasicDescription clientFormat, AudioStreamBasicDescription fileFormat, uint audioFileTypeID, RecorderDelegate aDelegate);

		// @property (readwrite) AudioStreamBasicDescription clientFormat;
		[Export ("clientFormat", ArgumentSemantic.Assign)]
		AudioStreamBasicDescription ClientFormat { get; set; }

		// @property (readonly) NSTimeInterval currentTime;
		[Export ("currentTime")]
		double CurrentTime { get; }

		// @property (readonly) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// @property (readonly) AudioStreamBasicDescription fileFormat;
		[Export ("fileFormat")]
		AudioStreamBasicDescription FileFormat { get; }

		// @property (readonly) NSString * formattedCurrentTime;
		[Export ("formattedCurrentTime")]
		string FormattedCurrentTime { get; }

		// @property (readonly) NSString * formattedDuration;
		[Export ("formattedDuration")]
		string FormattedDuration { get; }

		// @property (readonly) SInt64 frameIndex;
		[Export ("frameIndex")]
		long FrameIndex { get; }

		// @property (readonly) SInt64 totalFrames;
		[Export ("totalFrames")]
		long TotalFrames { get; }

		// -(NSURL *)url;
		[Export ("url")]
		NSUrl Url { get; }

		// -(void)appendDataFromBufferList:(AudioBufferList *)bufferList withBufferSize:(UInt32)bufferSize;
		[Internal]
		[Export ("appendDataFromBufferList:withBufferSize:")]
		unsafe void _AppendDataFromBufferList (IntPtr bufferList, uint bufferSize);

		// -(void)closeAudioFile;
		[Export ("closeAudioFile")]
		void CloseAudioFile ();
	}
}