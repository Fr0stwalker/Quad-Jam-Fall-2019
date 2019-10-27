using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTimerText : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTime(float time)
    {
        int minutes = Mathf.RoundToInt(time) / 60;
        int seconds = Mathf.RoundToInt(time) % 60;
        if (seconds < 10)
        {
            text.text = minutes + ":0" + seconds;
        }
        else
        {
            text.text = minutes + ":" + seconds;
        }
    }
}
