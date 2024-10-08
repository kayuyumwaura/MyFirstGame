using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void DoSomethingDelegate();

public class GameManager : MonoBehaviour
{
    ///contains rules of the game
    ///notifies other components of game-wide events (ui, player, etc.)
    ///responds to relevant changes in game states, and game objects - e.g, scoring, game health, etc.
    ///starts, pauses, resumes, ends... game life cyle
    ///
    ///

    
    public DoSomethingDelegate del1;

    private void Start()
    {
       
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            del1();
        }
    }



}
