using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    int score;
    public Text scoreText;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
