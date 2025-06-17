using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);  

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }
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
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
