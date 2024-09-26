using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class creates an asteroid every random seconds in a random location within the scene above the viewport
/// </summary>
public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public float maxSpawnRate = 1.0f;
    public float minSpawnRate = 1.0f;
    const float left = -9.0f;
    const float right = 8.86f;
    public bool isSpawning = false;
    public float timer = 0f;
    public float startTime = 0f;
    public float height = 9.0f;

    private void Start()
    {
        InvokeRepeating(nameof(PositionSpawnedAsteroid), startTime, timer);
    }

    private void PositionSpawnedAsteroid()
    {
        var roid = SpawnAsteroid();

        if (roid != null)
        {
            roid.transform.position = new Vector2(Random.Range(left, right), height);
        }
    }


   private GameObject SpawnAsteroid()
    {
        return Instantiate(asteroid);
    } 
}
