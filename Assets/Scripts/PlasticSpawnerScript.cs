using UnityEngine;

public class PlasticSpawnerScript : MonoBehaviour
{
    // Made public so that these can be changed from within Unity.
    [Header("Plastic Spawner")]
    public GameObject prefabToSpawn;
    public int spawnInterval = 2;

    // The below code is for a timer on how long it should take to spawn each prefab, the timer is also made public so that it can be be adjusted from within Unity.
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPrefab();
            timer = 0f;
        }
    }

    // The code below allows a prefab to be added to the script for a spawner GameObject in Unity.
    void SpawnPrefab()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
    }
}