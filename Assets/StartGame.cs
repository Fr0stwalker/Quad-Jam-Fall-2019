using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void OnStart()
    {
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
