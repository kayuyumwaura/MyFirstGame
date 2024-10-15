using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehavior : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameManager gameManager;

    public void HandleEarthDeath(Color color)
    {
        spriteRenderer.color = color;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
