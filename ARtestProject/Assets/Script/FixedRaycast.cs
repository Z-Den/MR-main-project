using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRaycast : MonoBehaviour
{
    [SerializeField] private GameObject _rightArm;
    [SerializeField] private GameObject _leftArm;

    private void FixedUpdate()
    {
        _rightArm = GameObject.Find("Right_ShellHandRayPointer(Clone)");
        _leftArm = GameObject.Find("Left_ShellHandRayPointer(Clone)");
        _rightArm.GetComponent<MixedRealityLineRenderer>().enabled = false;
        _rightArm.GetComponent<ShellHandRayPointer>().enabled = false;
        _leftArm.GetComponent<MixedRealityLineRenderer>().enabled = false;
        _leftArm.GetComponent<ShellHandRayPointer>().enabled = false;
    }
}
