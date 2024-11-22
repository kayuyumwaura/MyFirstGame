using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextBehavior : MonoBehaviour
{
    public TMP_Text ScoreText;

    public void UpdateScore(int Score)
    {
        ScoreText.text = Score.ToString();
    }
}
