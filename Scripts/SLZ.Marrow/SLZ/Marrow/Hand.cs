using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	public class Hand : MonoBehaviour
	{
		private static ComponentCache<Hand> _cache;

		public Action<HandReciever> onRecieverAttached;

		public Action<HandReciever> onRecieverDetached;

		public Action<HandReciever> onRecieverHoverBegin;

		public Action<HandReciever> onRecieverHoverEnd;

		public Action onRTSkeleFixedUpdateDelegate;

		public Action<Hand, Vector3> onAnchorUpdate;

		public Action<Hand, Vector3> onConnectedAnchorUpdate;

		private HandReciever _mHoveringReceiver;

		private HandReciever m_FarHoveringReciever;

		private GameObject m_CurrentAttachedGO;

		private const int m_ColliderArraySize = 128;

		private Collider[] m_OverlappingColliders;

		[SerializeField]
		private Collider[] m_HandColliders;

		private List<Collider> m_IgnoredColliders;

		private bool m_IsWarmup;

		public Collider collider;

		[HideInInspector]
		public Quaternion jointStartRotation;

		public ConfigurableJoint joint;

		public ConfigurableJoint tempJoint;

		[HideInInspector]
		public Rigidbody rb;

		[HideInInspector]
		public PhysHand physHand;

		[HideInInspector]
		public RigManager manager;

		public GameObject triggerRefProxyObject;

		public Handedness handedness;

		public Hand otherHand;

		public Transform palmPositionTransform;

		public LayerMask hoverLayerMask;

		public LayerMask farHoverLayerMask;

		public LayerMask playerLayerMask;

		public bool farHoverEnabled;

		private float _hoverSphereRadius;

		public HashSet<HandReciever> ignoredRecievers;

		private BaseController _controller;

		private SkeletonHand _skeleton;

		private HandPoseAnimator _animator;

		public InventorySlot slot;

		private ConfigurableJoint _forearmJoint;

		private ConfigurableJoint _upperarmJoint;

		private bool _isTriggerPulledOnAttach;

		private bool _indexButtonDown;

		private bool _indexButtonUp;

		private bool _indexButton;

		private float _indexTriggerAxis;

		public static ComponentCache<Hand> Cache => null;

		public float HoverSphereRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public BaseController Controller => null;

		public SkeletonHand Skeleton => null;

		public HandPoseAnimator Animator => null;

		public bool hoverLocked { get; private set; }

		public HandReciever AttachedReceiver { get; private set; }

		public HandReciever HoveringReceiver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HandReciever farHoveringReciever
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool GrabLock { get; private set; }

		private void OnLevelLoad()
		{
		}

		public void SetManager(RigManager m)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetGrabLock()
		{
		}

		public void AttachObject(GameObject objectToAttach)
		{
		}

		public void DetachJoint(bool isQuick = false, Grip lastGrip = null)
		{
		}
		private IEnumerator CoDelayDestroyJoint(ConfigurableJoint myJoint, bool isQuick, Grip lastGrip)
		{
			return null;
		}

		public void SetGripStrength(float perc)
		{
		}

		public SimpleTransform GetGripInHand()
		{
			return default(SimpleTransform);
		}

		public void UnignoreHostColliders(Grip grip)
		{
		}

		public void IgnoreHostColliders(Grip grip)
		{
		}

		public void PrepareJoint(GameObject objectToAttach, bool isSilent = false, Action OnBeforeAttach = null)
		{
		}

		public void AttachJoint(GameObject objectToAttach)
		{
		}

		public void AttachIgnoreBodyJoints(GameObject objectToAttach)
		{
		}

		public void DetachIgnoreBodyJoints()
		{
		}

		public void DisableCollider()
		{
		}

		public void EnableCollider()
		{
		}

		public void OnRTSkeleFixedUpdate()
		{
		}

		public void OnPhysRigEarlyUpdate()
		{
		}

		public void OnPhysRigUpdate()
		{
		}

		private static Quaternion SynthesizeRotation(Vector3 right, Vector3 up)
		{
			return default(Quaternion);
		}

		public float WristToForearmAngle()
		{
			return 0f;
		}

		public void DetachObject()
		{
		}

		private void UpdateHovering()
		{
		}

		public SimpleTransform GetHandleInWorld()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerWristTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(HandPose handPose, bool useSkeleOffset = false)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetControllerHandleTransform(bool useSkeleOffset = true)
		{
			return default(SimpleTransform);
		}

		public bool HasAttachedObject()
		{
			return false;
		}

		public void HoverLock()
		{
		}

		public void HoverUnlock()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}
		private IEnumerator CoJointBreakCooldown()
		{
			return null;
		}

		private void CreateConfigurableJoint()
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3), ConfigurableJoint j = null)
		{
		}

		public void UpdateConnectedAnchor(Vector3 connectedAnchor = default(Vector3))
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3), ConfigurableJoint j = null)
		{
		}

		public void UpdateAnchor(Vector3 anchor = default(Vector3))
		{
		}

		private void EarlyUpdateHeldObjectInputs()
		{
		}

		private void SetIndexButtonAndTrigger()
		{
		}

		public bool GetIndexButtonDown()
		{
			return false;
		}

		public bool GetIndexButtonUp()
		{
			return false;
		}

		public bool GetIndexButton()
		{
			return false;
		}

		public float GetIndexTriggerAxis()
		{
			return 0f;
		}
	}
}
