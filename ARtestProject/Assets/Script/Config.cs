using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Configs/ItemsConfig")]
public class Config : ScriptableObject
{
    public List<Item> Items;
}
