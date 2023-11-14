using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public void OnPress(GameObject spawnPrefab)
    {
        if (spawnPrefab.name == "Rot")
        {
            SpawnPrefab.transform.Rotate(new Vector3(0, 30, 0));
            return;
        }
        SpawnPrefab = Instantiate(spawnPrefab, Vector3.up, Quaternion.identity);
    }
}
