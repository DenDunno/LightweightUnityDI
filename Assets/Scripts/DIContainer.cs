using UnityEngine;

namespace LightweightUnityDI
{
    public class DIContainer 
    {
        public void RegisterType<T>()
        {
        }


        public void RegisterType<I, T>()
        {
        }


        public void RegisterInstance<T>(T instance)
        {
        }
    }
}