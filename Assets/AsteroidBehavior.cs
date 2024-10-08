using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public GameObject asteroidFX;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject spawnedFX = null;
        if (collision.CompareTag("Laser"))
        {
            spawnedFX = Instantiate(asteroidFX,transform.position, Quaternion.identity); //dictating how the asteroid spawns when destroyed, i.e, position
            Destroy(gameObject);
        }
        if (collision.CompareTag("AsteroidDestroyer"))
        {
            Destroy(gameObject);
        }
        Destroy(spawnedFX, 1.5f);
    }


}
