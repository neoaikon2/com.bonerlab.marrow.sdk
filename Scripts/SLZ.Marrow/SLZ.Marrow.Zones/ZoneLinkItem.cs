using SLZ.Marrow.Interaction;
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
#if UNITY_EDITOR
        protected virtual void Reset()
        {
            _zoneLink = GetComponent<ZoneLink>();
            if (_zoneLink != null || transform.parent == null)
                return;
            _zoneLink = transform.parent.GetComponent<ZoneLink>();
        }
#endif
        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void OnEnter(MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnExit(MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnSecondaryEnter(MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnPrimaryEnter(MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnPrimaryExit(MarrowEntity activatorEntity)
        {
        }

        protected virtual void OnSecondaryExit(MarrowEntity activatorEntity)
        {
        }
    }
}