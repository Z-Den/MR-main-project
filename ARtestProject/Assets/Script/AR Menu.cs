using Microsoft.MixedReality.Toolkit.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public partial class ARMenu : MonoBehaviour
{
    [SerializeField] private Config _itemsConfig;
    [SerializeField] private GameObject _buttonPrefab;
    [SerializeField] private Transform _root;
    [SerializeField] private GridObjectCollection gridObjectCollection;
    [SerializeField] private PlayerMoney _money;

    private void Start()
    {
        ButtonUpdate();
    }

    public void ButtonUpdate()
    {
        for(int i = 0; i < _root.childCount; i++)
        {
            Destroy(_root.GetChild(i).gameObject);
        }

        foreach(var item in _itemsConfig.Items)
        {
            if (!_money.CanBuy(item.Price))
            {
                continue;
            }
            var button = Instantiate(_buttonPrefab, _root);

            if (button.TryGetComponent(out ArButton arButton))
            {
                arButton.Initialize(item);
            }

            arButton.OnButtonClicked += () => ProcessBuy(item.Price, item.Prefab);
        }
        StartCoroutine(UpdateCollection());
    }

    private void ProcessBuy(int price, GameObject prefab)
    {
        _money.ProcessBuy(price, prefab);

        ButtonUpdate();
    }

    private IEnumerator UpdateCollection()
    {
        yield return new WaitForEndOfFrame();

        gridObjectCollection.UpdateCollection();
    }
}
