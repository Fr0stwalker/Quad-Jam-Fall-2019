using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void OnStart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
