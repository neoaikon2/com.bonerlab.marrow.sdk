 
 
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    public class ZoneItem : MonoBehaviour, IZoneEntityListenable
    {
        [SerializeField]
        protected Zone _zone;
        public MarrowQuery activatorTags = new();
        protected virtual void OnEnter(SLZ.Marrow.Interaction.MarrowEntity entity)
        {
        }

        protected virtual void OnExit(SLZ.Marrow.Interaction.MarrowEntity entity)
        {
        }

#if UNITY_EDITOR
        protected virtual void Reset()
        {
            var query = new TagQuery();
            BoneTagReference btRef = new BoneTagReference(MarrowSettings.RuntimeInstance.PlayerTag.Barcode);
            query.BoneTag = btRef;
            activatorTags.Tags.Add(query);
            _zone = GetComponent<Zone>();
            if (_zone != null || transform.parent == null)
                return;
            _zone = transform.parent.GetComponent<Zone>();
        }
#endif
    }
}