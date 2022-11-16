using JetBrains.Annotations;
using Unity.Entities;
using UnityEngine;

namespace Authoring
{
    public class SpherePrefabAuthoring : MonoBehaviour
    {
        public GameObject sphereSurfaceObject;
        public GameObject sphereOtherSurfaceObject;
    }

    public struct SpherePrefabComponent : IComponentData
    {
        public Entity SphereSurfaceObject;
        public Entity SphereOtherSurfaceObject;
    }

    [UsedImplicitly]
    public class SpherePrefabBaker : Baker<SpherePrefabAuthoring>
    {
        public override void Bake(SpherePrefabAuthoring authoring)
        {
            AddComponent(new SpherePrefabComponent()
            {
                SphereSurfaceObject = GetEntity(authoring.sphereSurfaceObject),
                SphereOtherSurfaceObject = GetEntity(authoring.sphereOtherSurfaceObject)
            });
        }
    }
}