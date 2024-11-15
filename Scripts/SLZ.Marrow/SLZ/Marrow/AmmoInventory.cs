using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow
{
	public class AmmoInventory : MonoBehaviour
	{
		[Header("AMMO")]
		public AmmoGroup lightAmmoGroup;

		public AmmoGroup mediumAmmoGroup;

		public AmmoGroup heavyAmmoGroup;

		public Action onAmmoUpdate;

		public Action<string, int> onAmmoUpdateCount;

		private Dictionary<string, int> _groupCounts;

		private Dictionary<string, string> _cartridgeToKey;

		private Dictionary<string, int> _AmmoCountsByCartridge;

		private Dictionary<CartridgeData, int> _cartridgeCounts;

		public static AmmoInventory Instance { get; private set; }

		private void Awake()
		{
		}

		private void RegisterAmmoGroup(AmmoGroup ammoGroup)
		{
		}

		public void ClearAmmo()
		{
		}

		public int GetCartridgeCount(CartridgeData cartridge)
		{
			return 0;
		}

		public int GetCartridgeCount(string groupKey)
		{
			return 0;
		}

		public void AddCartridge(CartridgeData cartridge, int count)
		{
		}

		public void AddCartridge(AmmoGroup ammoGroup, int count)
		{
		}

		public void RemoveCartridge(CartridgeData cartridge, int count)
		{
		}

		public string GetGroupByCartridge(CartridgeData cartridge)
		{
			return null;
		}
	}
}
