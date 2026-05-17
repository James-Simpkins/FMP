using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    void OnMouseDown() // When the player clicks on a GameObject with this script attached, run this code.
    {
        FindAnyObjectByType<ScoreManagerScript>().AddPoint(); // Tell the ScoreManager Script to add a point.
        Destroy(gameObject); // Wiple the clicked GameObject from memory as it is no longer needed.
    }
}