using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package Picked Up!");
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!");
            hasPackage = false;
        }
    }
}
