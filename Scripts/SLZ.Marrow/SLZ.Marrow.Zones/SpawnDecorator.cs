using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    [RequireComponent(typeof(CrateSpawner))]
    public class SpawnDecorator : MonoBehaviour, ISpawnListenable
    {
        [SerializeField]
        [ReadOnly]
        protected CrateSpawner _crateSpawner;
        public virtual void OnDespawn(GameObject go)
        {
        }
        public virtual void OnSpawn(GameObject go)
        {

        }
#if UNITY_EDITOR
        protected virtual void Reset()
        {
            _crateSpawner = GetComponent<CrateSpawner>();
        }
#endif
    }
}