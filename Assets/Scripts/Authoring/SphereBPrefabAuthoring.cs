using JetBrains.Annotations;
using Unity.Entities;
using UnityEngine;

namespace Authoring
{
    public class SphereBPrefabAuthoring : MonoBehaviour
    {
        public GameObject sphereSurfaceObject;
    }

    public struct SphereBPrefabComponent : IComponentData
    {
        public Entity SphereSurfaceObject;
    }

    [UsedImplicitly]
    public class SphereBPrefabBaker : Baker<SphereBPrefabAuthoring>
    {
        public override void Bake(SphereBPrefabAuthoring authoring)
        {
            AddComponent(new SphereBPrefabComponent()
            {
                SphereSurfaceObject = GetEntity(authoring.sphereSurfaceObject),
            });
        }
    }
}