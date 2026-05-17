using UnityEngine;

public class PlasticRightMovementScript : MonoBehaviour
{
    // Speed of movement
    public int speed = 1;

    void Start()
    {
        Destroy(gameObject, 20); // Automatically destroy the GameObject this script is attached to after 20 seconds, this is for optimisation.
    }

    void Update()
    {
        // Move the GameObject right every frame
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}