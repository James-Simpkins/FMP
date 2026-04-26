using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    void OnMouseDown() // When the player clicks on a GameObject, run this code.
    {
        Destroy(gameObject); // Wiple the clicked GameObject from memory as it is no longer needed.
    }
}