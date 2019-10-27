using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject mainGameCanvas;
    [SerializeField] private GameObject gameLogic;
    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void OnStart()
    {
        Time.timeScale = 1f;
        mainGameCanvas.SetActive(true);
        gameLogic.SetActive(true);
        Destroy(gameObject);
    }
}
