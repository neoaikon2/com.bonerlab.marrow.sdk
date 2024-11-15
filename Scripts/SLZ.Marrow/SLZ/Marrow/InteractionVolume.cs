using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow
{
	public class InteractionVolume : MonoBehaviour
	{
		public struct InteractableEvent
		{
			public Collider collider;

			public HandReciever interactable;
		}

		public enum Type
		{
			Box = 0,
			Sphere = 1,
			Capsule = 2
		}

		public enum Direction
		{
			xAxis = 0,
			yAxis = 1,
			zAxis = 2
		}
		public static Dictionary<IGrippable, int> ClaimedHosts;

		[HideInInspector]
		public bool isActive;

		private Collider[] interactableColliders;

		private Rigidbody rb;

		private Rigidbody _hoveringRigidbody;

		private InteractableHost hoveringInteractableHost;

		private Coroutine checkCollisionsCoroutine;

		private bool _tempActive;

		private Rigidbody hoveringRigidbody
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static void AddClaimedHost(IGrippable host)
		{
		}

		public static void RemoveClaimedHost(IGrippable host)
		{
		}

		protected virtual void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerStay(Collider c)
		{
		}
		private IEnumerator ExecuteInteraction()
		{
			return null;
		}

		protected virtual void OnHoverUpdate(InteractableHost host)
		{
		}

		protected virtual void OnHoverStart(InteractableHost host)
		{
		}

		protected virtual void OnHoverEnd(InteractableHost host)
		{
		}
	}
}
