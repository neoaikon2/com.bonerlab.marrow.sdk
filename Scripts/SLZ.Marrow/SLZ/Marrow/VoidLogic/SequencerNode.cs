using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Sequencer")]
	[Support(SupportFlags.AlphaSupported, "This needs to be updated to use sensors and actuators.")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SequencerNode")]
	public class SequencerNode : BaseNode
	{
		private bool _isRunning;

		private float _time;

		private float _cachedEndKeyTime;

		private float _cachedValue;

		private static readonly PortMetadata _portMetadata;

		[field: FormerlySerializedAs("_sequence")]
		[field: SerializeField]
		[field: Tooltip("Timing sequence")]
		private AnimationCurve Sequence { get; set; }

		[field: Tooltip("Exempt from slow-mo (advance in realtime instead of abiding by timescale)")]
		[field: SerializeField]
		[field: FormerlySerializedAs("_realtime")]
		public bool RealTime { get; private set; }

		[field: SerializeField]
		[field: Tooltip("Duration of a default animation curve at default speed (timed from t=0 to 1, speed input = 1).")]
		public float TimeScale { get; private set; }

		[field: SerializeField]
		[field: Tooltip("Repeat the sequence, keeping it running until reset")]
		[field: FormerlySerializedAs("_loop")]
		public bool Loop { get; private set; }

		[field: Tooltip("Resets the timing to the beginning after it completes")]
		[field: SerializeField]
		public bool ResetTimeOnSequenceCompletion { get; private set; }

		[field: Tooltip("Edge detection configuration for start input")]
		[field: SerializeField]
		private EdgeDetector StartEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for reset input")]
		[field: SerializeField]
		private EdgeDetector ResetEdgeDetector { get; set; }

		public override PortMetadata PortMetadata => default(PortMetadata);

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
