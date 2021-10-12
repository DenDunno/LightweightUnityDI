using System.Collections.Generic;
using UnityEngine;

namespace LightweightUnityDI
{
    public class DIEntryPoint : MonoBehaviour
    {
        [SerializeField] private List<MonoBehaviour> _objectsWithDependencies = null;


        public void SetObjectsWithDependencies(List<MonoBehaviour> objectsWithDependencies)
        {
            _objectsWithDependencies = objectsWithDependencies;
            Debug.Log("<color=#3EEC49>Success: </color>Objects with dependencies were added to list");
        }
    }
}