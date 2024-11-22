using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthHealth : MonoBehaviour
{

    private const float MaxHealth = 5f;
    private float currentHealth;
    public GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    public Image healthBar;

    private void HandleDelegate()
    {
        CurrentHealth += 200;
    }

    //this is a property of currentHealth that protects(controlled access) of currentHealth
    public float CurrentHealth { get { return currentHealth; }  private set { 
            currentHealth = value;
            healthBar.fillAmount = currentHealth / MaxHealth;

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
        healthBar.fillAmount = 1f;

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
