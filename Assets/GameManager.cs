using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


//public delegate void DoSomethingDelegate(Color color);
//public event DoSomethingDelegate OnEarthDeath;

public class GameManager : MonoBehaviour
{
    ///contains rules of the game
    ///notifies other components of game-wide events (ui, player, etc.)
    ///responds to relevant changes in game states, and game objects - e.g, scoring, game health, etc.
    ///starts, pauses, resumes, ends... game life cyle
    ///
    ///

    //this is a delegate wrapped in an event - making it immutable, and perfect for publishing and subscribing. see delegate method above
   
    public UnityEvent<Color> OnEarthDeath;
    public UnityEvent<int> OnScoreUpdate;
    private int CurrentScore;
    public static GameManager instance;


    private void Start()
    {
       instance = this;
    }

    public void IncrementScore()
    {
        CurrentScore += 10;
        OnScoreUpdate?.Invoke(CurrentScore);
    }

    /// <summary>
    /// called by earth health when earth health is zero
    /// </summary>
    internal void NotifyEarthDeath()
    {
        OnEarthDeath.Invoke(Color.red);
        SceneManager.LoadScene("GamePlay");
    }





}
