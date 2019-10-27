using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallStartGameCanvas : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    public void StartGameCanvas()
    {
        canvas.SetActive(true);
    }
}
