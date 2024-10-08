using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthHealth : MonoBehaviour
{

    private const int MaxHealth = 100;
    private int currentHealth;
    public GameManager gameManager;

    private void HandleDelegate()
    {
        CurrentHealth += 200;
    }

    //this is a property of currentHealth that protects(controlled access) of currentHealth
    public int CurrentHealth { get { return currentHealth; }  private set { 
            currentHealth = value;

            Debug.Log("Manager has set my health to " + currentHealth);
        } }

    ////a broken down version of the property CurrentHealth
    //public int GetHealth()
    //{
    //    return currentHealth;
    //}

    //public void SetHealth(int value)
    //{
    //    currentHealth = value;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid"))
        {
            CurrentHealth -= 10;
            //Debug.Log("Earth Hit");
        }
    }

    private void Start()
    {
        gameManager.del1 = new DoSomethingDelegate(HandleDelegate);
    }

    void Update()
    {
        
    }
}
