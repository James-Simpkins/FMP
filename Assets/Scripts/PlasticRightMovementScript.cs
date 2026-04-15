using UnityEngine;

public class PlasticRightMovementScript : MonoBehaviour
{
    // Speed of movement
    public float speed = 1f;

    void Update()
    {
        // Move the GameObject right every frame
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}