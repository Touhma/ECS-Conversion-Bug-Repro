using JetBrains.Annotations;
using Unity.Entities;
using UnityEngine;

namespace Authoring
{
    public class SphereAPrefabAuthoring : MonoBehaviour
    {
        public GameObject sphereOtherSurfaceObject;
    }

    public struct SphereAPrefabComponent : IComponentData
    {
        public Entity SphereOtherSurfaceObject;
    }

    [UsedImplicitly]
    public class SphereAPrefabBaker : Baker<SphereAPrefabAuthoring>
    {
        public override void Bake(SphereAPrefabAuthoring authoring)
        {
            AddComponent(new SphereAPrefabComponent()
            {
                SphereOtherSurfaceObject = GetEntity(authoring.sphereOtherSurfaceObject)
            });
        }
    }
}