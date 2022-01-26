using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject[] planePrefabs;
    public GameObject gameOverText;
    private float spawnRangeX = 125f;
    private float spawnRangeZ = 170f;
    private float spawnDelay = 0;
    private float spawnIntervall = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Beginn of spawn process
        InvokeRepeating("SpawnRandomPlane", spawnDelay, spawnIntervall);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isGameActive)
        {
            gameOverText.SetActive(true);
        }

    }

    void SpawnRandomPlane()
    {
        if (GameManager.Instance.isGameActive)
        {
            int planeIndex = Random.Range(0, planePrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

            // Spawn Animal with upper characteristics
            Instantiate(planePrefabs[planeIndex], spawnPos, planePrefabs[planeIndex].transform.rotation);
        }
  
    }
}