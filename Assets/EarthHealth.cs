using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthHealth : MonoBehaviour
{

    private const int MaxHealth = 5;
    private int currentHealth;
    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;

    private void HandleDelegate()
    {
        CurrentHealth += 200;
    }

    //this is a property of currentHealth that protects(controlled access) of currentHealth
    public int CurrentHealth { get { return currentHealth; }  private set { 
            currentHealth = value;

            if (currentHealth <= 0)
            {
                gameManager.NotifyEarthDeath(); 
            }
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
            CurrentHealth -= 1;
            //Debug.Log("Earth Hit");
        }
    }

  

    private void Start()
    {
        CurrentHealth = MaxHealth;

        //gameManager.del1 = new DoSomethingDelegate(HandleDelegate);
    }

    void Update()
    {
        
    }

    public void HandleEarthDeath(Color color)
    {
        spriteRenderer.color = color;
    }
}
