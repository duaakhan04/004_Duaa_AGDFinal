using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Assign the Cube Prefab in Inspector
    public float spawnInterval = 2f; // Time in seconds between spawns

    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

