using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace challenge
{
    public class GenericChallenge1 : MonoBehaviour
    {
        public GameObject prefab;

        // Start is called before the first frame update
        void Start()
        {
            //CreateObject<GameObject>();
            CustomAddComponent<EmptyComponentScript>(gameObject);
        }


        private void CreateObject<T>(GameObject prefab)
        {

            if (!Input.GetButtonDown("Fire1"))
            {
                Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
        private void LogComponent<T>(T component) where T : Component
        {
            Debug.Log($"Generics Test {typeof(T)} | {component}");
        }

        private void CustomAddComponent<T>(GameObject gameObject) where T : MonoBehaviour
        {
            var component = gameObject.AddComponent<T>();
            component.enabled = true;

            Debug.Log($"Generics Test {typeof(T)} /n {gameObject.GetComponents<T>().Length}");
        }
        private void CustomDeleteComponent<T>(GameObject gameObject) where T : MonoBehaviour
        {
            var component = gameObject.AddComponent<T>();
            component.enabled = false;

            Debug.Log($"Generics Test {typeof(T)} /n {gameObject.GetComponents<T>().Length}");
        }
    }
}
