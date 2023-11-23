using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRaycast : MonoBehaviour
{
    private void FixedUpdate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<MixedRealityLineRenderer>()) transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
