using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow
{
	[Serializable]
	public class Servo : MonoBehaviour
	{
		private enum RotationJointType
		{
			None = 0,
			Revolute = 1,
			ZeroTwist = 2,
			Spherical = 3
		}

		[SerializeField]
		private ConfigurableJoint _joint;

		private Rigidbody _rb;

		private Quaternion _initialRotation;

		private Quaternion _toJointSpace;

		private Quaternion _toJointSpaceInv;

		private Quaternion _toJointSpaceFromDefault;

		private RotationJointType _rotationJointType;

		public ConfigurableJoint joint => null;

		public MarrowBody marrowBody { get; private set; }

		public JointDrive xDriveBase { get; set; }

		public JointDrive yDriveBase { get; set; }

		public JointDrive zDriveBase { get; set; }

		public JointDrive angularXDriveBase { get; set; }

		public JointDrive angularYZDriveBase { get; set; }

		public JointDrive slerpDriveBase { get; set; }

		public Quaternion initialRotation => default(Quaternion);

		private void Start()
		{
		}

		public virtual void Initiate()
		{
		}

		public Vector3 GetConnectedAnchorInWorld()
		{
			return default(Vector3);
		}

		[MethodImpl(256)]
		public float GetTwistInDegrees()
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float GetTwistInDegrees(Quaternion rotationToTest)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float GetSwingInDegrees()
		{
			return 0f;
		}

		public float GetSwingInDegrees(out Vector2 yPositiveAlignsToSecAxis)
		{
			yPositiveAlignsToSecAxis = default(Vector2);
			return 0f;
		}

		public float GetSwingInLimitPercent(out Vector2 yPositiveAlignsToSecAxis)
		{
			yPositiveAlignsToSecAxis = default(Vector2);
			return 0f;
		}

		[MethodImpl(256)]
		public float GetTwistInLimitPercent()
		{
			return 0f;
		}

		public void SetXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetYDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularYZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetSlerpDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetYDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularYZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetSlerpDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetLinearLimitSpring(float spring, float damper)
		{
		}

		public void SetAngularXLimitSpring(float spring, float damper)
		{
		}

		public void SetAngularYZLimitSpring(float spring, float damper)
		{
		}

		private JointDrive ComputeJointDrive(JointDrive driveBase, float springMult, float damperMult, float maxForceMult)
		{
			return default(JointDrive);
		}

		public void FreeAllConstraints()
		{
		}

		private JointDrive SetJointDrive(float spring, float damper, float maxForce)
		{
			return default(JointDrive);
		}

		private SoftJointLimitSpring SetLimitSpring(float spring, float damper)
		{
			return default(SoftJointLimitSpring);
		}

		public void SetJointLimitsAll(float linearLimit, Vector4 angularLimits)
		{
		}

		public void SetTargetRotationLocal(Quaternion targetLocal)
		{
		}

		public void SetTargetRotationAndAngVelocityLocal(Quaternion targetLocal, float deltaTime)
		{
		}

		public void SetTargetTwistInDegrees(float targetTwist)
		{
		}

		public void SetTargetPositionLocal(Vector3 targetLocalPosition, Quaternion targetLocalRotation)
		{
		}
	}
}
