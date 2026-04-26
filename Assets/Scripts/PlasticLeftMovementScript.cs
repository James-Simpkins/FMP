using UnityEngine;

public class PlasticLeftMovementScript : MonoBehaviour
{
    // Speed of movement
    public int speed = 1;

    void Update()
    {
        // Move the GameObject right every frame
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}