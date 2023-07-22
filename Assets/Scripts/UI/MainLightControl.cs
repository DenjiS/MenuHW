using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLightControl : MonoBehaviour
{
    [SerializeField] private Light _mainLight;

    public void ChangeIntensity(float intensity)
    {
        _mainLight.intensity = intensity;
    }
}
