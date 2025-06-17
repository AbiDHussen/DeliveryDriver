using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 100.0f;
    [SerializeField] float carSpeed = 10.0f;
    [SerializeField] float slowSpeed = 15.0f;
    [SerializeField] float boostSpeed = 30.0f;
   
    void Update() 
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, speedAmount, 0);    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        carSpeed = slowSpeed;
        Debug.Log("speed slowed down!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            carSpeed = boostSpeed;
            Debug.Log("Boost Activated!");
        }
    }
}
