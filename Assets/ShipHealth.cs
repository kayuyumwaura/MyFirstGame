using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour

{
    public SpriteRenderer spriteRenderer;
    public GameManager gameManager;

    public void HandleEarthDeath(Color color)
    {
        spriteRenderer.color = color;
    }

   
}
