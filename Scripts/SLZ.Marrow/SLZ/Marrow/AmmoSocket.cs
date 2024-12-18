using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow
{
	public class AmmoSocket : Socket
	{
		[Header("Magazine Socket")]
		public string platform;

		[Header("References")]
		public Grip primaryGrip;

		public Gun gun;

		public bool despawnOnInsert;

		private bool _isHostGrabbed;

		private bool _isMagazineInserted;

		private bool _isProxyGripState;

		private AmmoPlug _magazinePlug;

		public Action<Hand, Gun> onUpdateProxyGripState;

		public override bool IsClearOnInsert => false;

		public bool HasMagazine => false;

		protected override void Awake()
		{
		}

		public InteractableHost GetHost()
		{
			return null;
		}

		private void OnPlugLocked(Plug plug)
		{
		}

		private void OnPlugUnlocked()
		{
		}

		protected override void OnPlugEnter(Plug plug)
		{
		}

		protected override void OnPlugExit(Plug plug)
		{
		}

		private void UpdateProxyGripState(Hand hand)
		{
		}

		public void EjectMagazine()
		{
		}

		private void UpdateMagGripPriority(int ammoCount)
		{
		}

		private void OnAttachedHandDelegate(InteractableHost host, Hand hand)
		{
		}

		private void OnDetachedHandDelegate(InteractableHost host, Hand hand)
		{
		}
		public UniTask ForceLoadAsync(MagazineData magazineData)
		{
			return default(UniTask);
		}

		public override void OnDespawn()
		{
		}
	}
}
