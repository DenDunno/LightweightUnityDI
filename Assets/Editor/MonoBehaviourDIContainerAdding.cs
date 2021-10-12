using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace LightweightUnityDI
{
    public class MonoBehaviourDIContainerAdding : Editor
    {
        [MenuItem("CONTEXT/DIEntryPoint/Get MonoBehaviours with dependencies")]
        public static void GetMonoBehavioursWithDependencies(MenuCommand command)
        {
            MonoBehaviour[] allMonoBehaviors = FindObjectsOfType<MonoBehaviour>();
            var monoBehavioursWithDependencies = new List<MonoBehaviour>();

            foreach (MonoBehaviour monoBehavior in allMonoBehaviors)
            {
                FieldInfo[] fields = monoBehavior.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

                if (fields.Any(fieldInfo => fieldInfo.GetCustomAttribute<LightweightDependencyAttribute>() != null))
                {
                    monoBehavioursWithDependencies.Add(monoBehavior);
                }
            }

            (command.context as DIEntryPoint)?.SetObjectsWithDependencies(monoBehavioursWithDependencies);
        }
    }
}