using UnityEngine;

public class DiamondCollect : MonoBehaviour
{
    public DiamondManager diamondManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided with" + other.gameObject.name);
        
        if (other.gameObject.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
            diamondManager.diamondCount++;
        }
        
    }
}
