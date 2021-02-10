using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public static partial class BuliderExtension
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddSprite(this GameObject gameObject, Sprite sprite)
        {
            var component = gameObject.GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return gameObject;
        }

        public static GameObject AddTrailRenderer(this GameObject gameObject)
        {
            var componentInChildren = gameObject.GetComponentInChildren<TrailRenderer>();
            if (componentInChildren)
            {
                return gameObject;
            }

            var trailRendererGameObject = new GameObject("TrailRenderer");
            var trailRenderer = trailRendererGameObject.AddComponent<TrailRenderer>();
            trailRenderer.startWidth = 0.1f;
            trailRenderer.endWidth = 0.01f;
            trailRenderer.time = 0.1f;
            trailRenderer.material = new Material(Shader.Find("Mobile/Particles/Additive"));
            trailRenderer.startColor = Color.red;
            trailRenderer.endColor = Color.blue;
            trailRendererGameObject.transform.SetParent(gameObject.transform);

            return gameObject;
        }

        private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            
            if (!component)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }

    }
}
