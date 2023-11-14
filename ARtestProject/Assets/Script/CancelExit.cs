using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelExit : MonoBehaviour
{
    [SerializeField] private GameObject Conf;
    [SerializeField] private GameObject Canc;

    public void OnPress()
    {
        Conf.SetActive(false);
        Canc.SetActive(false);
    }
}
