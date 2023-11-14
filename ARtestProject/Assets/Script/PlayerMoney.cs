using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int moneyAmount;
    [SerializeField] private ItemSpawn _itemSpawn;

    public void ProcessBuy(int money, GameObject prefab)
    {
        if(moneyAmount - money < 0)
        {
            return;
        }

        moneyAmount -= money;
        
        _itemSpawn.OnPress(prefab);
    }

    public bool CanBuy(int price)
    {
        return moneyAmount - price >= 0;
    }
}
