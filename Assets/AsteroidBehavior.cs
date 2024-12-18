using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public GameObject asteroidFX;
    GameObject spawnedFX = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Laser"))
        {
            GameManager.instance.IncrementScore();
            DestroyAsteroid();
        }
        if (collision.CompareTag("AsteroidDestroyer"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Earth"))
        {
            Debug.Log("Earth Hit");
            DestroyAsteroid();
        }
        Destroy(spawnedFX, 1.5f);
    }

    private void DestroyAsteroid()
    {
        spawnedFX = Instantiate(asteroidFX, transform.position, Quaternion.identity); //dictating how the asteroid spawns when destroyed, i.e, position
        Destroy(gameObject);
    }
}
