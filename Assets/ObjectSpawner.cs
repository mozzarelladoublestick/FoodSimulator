using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject burger;
    public Vector3 spawnAreaCenter;
    public Vector3 spawnAreaSize;
    public float spawnInterval = 1f;

    private void Start()
    {

    }
    private void Update()
    {
        if (EnterIngredient.finished == true)
        {
            InvokeRepeating("SpawnObject", 0f, spawnInterval);
        }
    }

    private void SpawnObject()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnAreaCenter.x - spawnAreaSize.x / 2, spawnAreaCenter.x + spawnAreaSize.x / 2),
            Random.Range(spawnAreaCenter.y - spawnAreaSize.y / 2, spawnAreaCenter.y + spawnAreaSize.y / 2),
            Random.Range(spawnAreaCenter.z - spawnAreaSize.z / 2, spawnAreaCenter.z + spawnAreaSize.z / 2)
        );

        Instantiate(burger, randomPosition, Quaternion.identity);
    }

}