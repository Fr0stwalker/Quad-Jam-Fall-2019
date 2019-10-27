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
        text.text = minutes+":"+seconds;
    }
}
