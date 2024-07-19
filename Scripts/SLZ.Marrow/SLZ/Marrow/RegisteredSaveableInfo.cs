using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		[field: SerializeField]
		[field: ReadOnly(false)]
		public Saveable Saveable { get; private set; }

		[field: SerializeField]
		[field: ReadOnly(false)]
		public string UniqueId { get; private set; }

		public RegisteredSaveableInfo(Saveable saveable, string uniqueId)
		{
		}
	}
}
