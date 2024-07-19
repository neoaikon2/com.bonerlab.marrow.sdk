using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneLight : ZoneLinkItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;

		[Header("Light properties")]
		[Range(0f, 180f)]
		[SerializeField]
		[Space(5f)]
		private float SpotLightAngle;

		[SerializeField]
		private float LightRange;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		private bool EnableShadows;

		[SerializeField]
		[HideInInspector]
		private GameObject LightObject;

		[SerializeField]
		[HideInInspector]
		private Light SourceLight;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		private void DisableLight()
		{
		}

		private void EnableLight()
		{
		}

		private void ChangeLightSettings()
		{
		}
	}
}
