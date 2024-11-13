using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Toggle")]
	public class ToggleNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		public bool Value { get; set; }

		[field: SerializeField]
		[field: Tooltip("Edge detection configuration for set input")]
		private EdgeDetector SetEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for reset input")]
		[field: SerializeField]
		private EdgeDetector ResetEdgeDetector { get; set; }

		public override PortMetadata PortMetadata => default(PortMetadata);

		public ToggleNode()
		{
			SetEdgeDetector = new EdgeDetector();
			ResetEdgeDetector = new EdgeDetector();
		}

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
