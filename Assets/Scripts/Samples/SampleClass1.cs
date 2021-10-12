using LightweightUnityDI;
using UnityEngine;

public class SampleClass1 : MonoBehaviour
{
    [LightweightDependency] private readonly SampleClass2 _sampleClass2;
    private int a = 10;

    public void SayHisName()
    {
        _sampleClass2.SayMyName();
    }
}