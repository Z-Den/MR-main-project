using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    
    public void ToDelete()
    {
        Debug.Log("Destroyed");
        Destroy(gameObject.transform.parent.gameObject);
        
    }
}
