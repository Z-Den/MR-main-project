using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    private int moneyAmount = 4000;
    [SerializeField] private ItemSpawn _itemSpawn;
    public int moni;
    public void ProcessBuy(int money, GameObject prefab)
    {
        if(moneyAmount - money < 0)
        {
            return;
        }

        moneyAmount -= money;
        
        _itemSpawn.OnPress(prefab);
        moni = moneyAmount;
    }

    public bool CanBuy(int price)
    {
        return moneyAmount - price >= 0;
    }
}
