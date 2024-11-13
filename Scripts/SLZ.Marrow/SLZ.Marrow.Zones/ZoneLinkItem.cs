using System;
 
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    public class ZoneLinkItem : MonoBehaviour, IZoneLinkListenable, IZoneLinkPrimaryListenable, IZoneLinkSecondaryListenable
    {
        [Flags]
        public enum EventTypes
        {
            Primary = 1 << 0,
            Secondary = 1 << 1
        }

        [SerializeField]
        protected ZoneLink _zoneLink;
        [EnumFlags, SerializeField]
        protected EventTypes _eventTypes = EventTypes.Primary | EventTypes.Secondary;

        protected virtual void OnEnter(SLZ.Marrow.Interaction.MarrowEntity activatorEntity) {}
        protected virtual void OnExit(SLZ.Marrow.Interaction.MarrowEntity activatorEntity) {}
        protected virtual void OnEnable() { }
        protected virtual void OnDisable() { }
        protected virtual void OnPrimaryEnter(SLZ.Marrow.Interaction.MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnPrimaryExit(SLZ.Marrow.Interaction.MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnSecondaryEnter(SLZ.Marrow.Interaction.MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnSecondaryExit(SLZ.Marrow.Interaction.MarrowEntity activatorEntity)
        {
        }

#if UNITY_EDITOR
        protected virtual void Reset()
        {
            _zoneLink = GetComponent<ZoneLink>();
            if (_zoneLink != null || transform.parent == null)
                return;
            _zoneLink = transform.parent.GetComponent<ZoneLink>();
        }
#endif
    }
}