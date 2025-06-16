using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger entered with: " + collision.gameObject.name);
    }
}
