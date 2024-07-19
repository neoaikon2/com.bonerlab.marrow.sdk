using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Multiply")]
	[Support(SupportFlags.Supported, null)]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MultiplyNode")]
	public class MultiplyNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
