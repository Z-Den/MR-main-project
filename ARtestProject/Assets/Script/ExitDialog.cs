using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDialog : MonoBehaviour
{
    [SerializeField] private GameObject Conf;
    [SerializeField] private GameObject Canc;

    public void OnPress()
    {
        Conf.SetActive(true);
        Canc.SetActive(true);
    }
}
