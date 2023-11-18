using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAll : MonoBehaviour
{
    [SerializeField] PlayerMoney _money;
    [SerializeField] private ARMenu _arMenu;


    public void destroy()
    {
        GameObject[] _objects = GameObject.FindGameObjectsWithTag("Spawned");
        foreach (GameObject obj in _objects)
        {
            Destroy(obj);
            _money.ProcessBuy(_money.moni - 4000, null);
        }
        _arMenu.ButtonUpdate();
    }
}
