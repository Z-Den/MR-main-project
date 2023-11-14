using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SliderController : MonoBehaviour
{
    [SerializeField] private GameObject _light;
    [SerializeField] private PinchSlider _slider;

    public void SetLight()
    {
        if( _slider.SliderValue > 0)
            _light.transform.rotation = new Quaternion(1, Mathf.Log10(_slider.SliderValue), 1, 1);
    }
}
