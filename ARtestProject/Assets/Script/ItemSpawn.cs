using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    private GameObject SpawnPrefab;
    [SerializeField] private PlayerMoney money;
    private List<GameObject> spawnList = new List<GameObject>();
    public void OnPress(GameObject spawnPrefab)
    {
        if (spawnPrefab == null) return;
        if (spawnPrefab.name == "Rot")
        {
            spawnList[spawnList.Count - 1].transform.Rotate(new Vector3(0, 30, 0));
            return;
        }
        if (spawnPrefab.name == "Del")
        {
            ToDelete();
            return;
        }
        if (spawnPrefab.name == "Reset")
        {
            spawnList[spawnList.Count - 1].transform.position = Vector3.up;
            spawnList[spawnList.Count - 1].transform.rotation = Quaternion.identity;
            return;
        }
        SpawnPrefab = Instantiate(spawnPrefab, Vector3.up, Quaternion.identity);
        spawnList.Add(SpawnPrefab);
    }
    public void ToDelete()
    {
        GameObject delObject = spawnList[spawnList.Count - 1];
        Destroy(delObject);
        spawnList.Remove(delObject);
        money.ProcessBuy(money.moni - 4000, null);
    }
}
