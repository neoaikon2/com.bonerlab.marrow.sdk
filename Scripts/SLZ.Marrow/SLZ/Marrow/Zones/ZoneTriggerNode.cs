using System;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[Support(SupportFlags.Unsupported, "Not (yet?) supported.")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Zone Trigger")]
	public class ZoneTriggerNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver, IVoidLogicSource
	{
		[SerializeField]
		private Zone _zone;

		public EntityAggregator aggregator;

		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Obsolete("Replace with `_previousConnections`")]
		private MonoBehaviour[] _previous;

		[NonReorderable]
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		protected internal OutputPortReference[] _previousConnections;

		public UltEvent<MarrowBody> OnBodyTriggerEnter;

		public UltEvent<MarrowBody> OnBodyTriggerExit;

		public UltEvent<MarrowEntity> OnEntityTriggerEnter;

		public UltEvent<MarrowEntity> OnEntityTriggerExit;

		[ReadOnly(false)]
		[SerializeField]
		private float logicMultiplier;

		protected internal float _cachedValue;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		protected bool IsCachedInternal { get; private set; }

		public int OutputCount => 0;

		public int InputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSource_002ECalculate(ref NodeState nodeState)
		{
		}

		public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
		{
			connectedPort = default(OutputPortReference);
			return false;
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return false;
		}

		public void Calculate(ref NodeState nodeState)
		{
			throw new NotImplementedException();
		}

		public void OnBeforeSerialize()
		{
			throw new NotImplementedException();
		}

		public void OnAfterDeserialize()
		{
			throw new NotImplementedException();
		}
	}
}
