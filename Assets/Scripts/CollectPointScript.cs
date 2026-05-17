using UnityEngine;

public class CollectPointScript : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        FindAnyObjectByType<ScoreManagerScript>().AddPoint();
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }
}
