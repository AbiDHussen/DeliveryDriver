using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject MyCar; // Reference to the car GameObject
    void LateUpdate()
    {
        transform.position = MyCar.transform.position + new Vector3(0, 0, -10);
    }
}
