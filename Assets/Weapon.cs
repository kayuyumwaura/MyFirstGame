using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform gunPosition;
    public float fireRate = 0.5f;
    private float timer = 0f;
    private bool canFire = false;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < Mathf.Epsilon)
        {
            canFire = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canFire == true)
        {
            Instantiate(laserPrefab, gunPosition.position, Quaternion.identity);
            canFire = false;
            timer = fireRate;
        }
    }
}
