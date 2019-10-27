using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private int minutes;
    [SerializeField] private int seconds;
    [SerializeField] private GameObject gameOverCanvas;

    private float actualTime;

    private UpdateTimerText updateTimerText;
    private void Start()
    {
        updateTimerText = FindObjectOfType<UpdateTimerText>();
        actualTime = seconds + (minutes * 60);
        Debug.Log("Actual time:"+actualTime);
    }

    private void FixedUpdate()
    {
        if (actualTime > 0)
        {
            Debug.Log("Actual time:" + actualTime);
            updateTimerText.UpdateTime(actualTime);
            actualTime = actualTime - Time.deltaTime;
        }
        else
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
