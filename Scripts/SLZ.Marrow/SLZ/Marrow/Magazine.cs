using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	public class Magazine : SpawnEvents
	{
		[SerializeField]
		public MagazineState magazineState;

		[Header("References")]
		public AmmoPlug magazinePlug;

		public Grip grip;

		public Transform insertPointTransform;

		public InteractableHost interactableHost;

		public GameObject firstCartridgeTarget;

		public GameObject secondCartridgeTarget;

		private FirearmCartridge _firstCartridgeArt;

		private FirearmCartridge _secondCartridgeArt;

		private bool _isInitalized;

		private bool _isArtHidden;

		private bool _isMagazineClaimed;

		private AmmoInventory _lastAmmoInventory;

		private InventoryAmmoReceiver _lastAmmoInventoryReceiver;

		public SimpleTransform ammoPouchOffset;

		[HideInInspector]
		public bool isMagazineInserted;

		public bool ignoreSecondBulletSpawn;

		public override void OnPoolInitialize()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		public bool IsClaimed()
		{
			return false;
		}

		public void Claim()
		{
		}

		public void Initialize(CartridgeData cartridgeData, int count)
		{
		}
		public UniTask InitializeAsync(CartridgeData cartridgeData, int count)
		{
			return default(UniTask);
		}

		private FirearmCartridge ApplyBulletArt(GameObject go, Transform parent)
		{
			return null;
		}

		private void OnAmmoChange(int ammount)
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		public void OnEject()
		{
		}

		public void OnInsert()
		{
		}

		private void HideBulletArt()
		{
		}

		private void ShowBulletArt()
		{
		}

		private void SetCartActive(FirearmCartridge cartridge, bool isActive)
		{
		}

		public void CheckBulletArt()
		{
		}
	}
}
