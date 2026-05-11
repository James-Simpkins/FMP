using UnityEngine;

public class CollectPointScript : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 2f; // Needed? Unity Editor 6000.0.37f1 displays a warning says it is never used.

    [SerializeField] AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        //if (!GameManagerBehavior.isPaused)
        //{
        //    transform.Rotate(0, rotationSpeed, 0);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        FindAnyObjectByType<ScoreManagerScript>().AddPoint();
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }
}
