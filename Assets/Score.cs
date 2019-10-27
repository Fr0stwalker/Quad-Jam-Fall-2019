using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score=0;
    private UpdateScoreText updateScoreText;
    private void Start()
    {
        updateScoreText = FindObjectOfType<UpdateScoreText>();
        updateScoreText.UpdateScore(score);
    }

    public void SetScore(int scoreIncrease)
    {
        score += scoreIncrease;
        updateScoreText.UpdateScore(score);
    }
}
