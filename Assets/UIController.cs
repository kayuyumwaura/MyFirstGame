using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public GameObject gameOverMenu;
    public TMP_Text highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    public void SetHighScore()
    {
        highScoreText.text = PlayerPrefs.GetInt("high score").ToString();
        gameOverMenu.SetActive(true);
    }

    public void RestartGame()
    {
        GameManager.instance.RestartGame();
    }

    public void QuitGame()
    {
        GameManager.instance.QuitGame();
    }
}
