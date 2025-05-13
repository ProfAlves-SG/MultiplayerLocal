using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    [SerializeField] private float timeMatch = 0f;
    [SerializeField] private TextMeshProUGUI textTimer;


    private void Update()
    {
        timeMatch += Time.deltaTime;
        UpdateTimerUi();
    }

    private void UpdateTimerUi()
    {
        int minutes = Mathf.FloorToInt(timeMatch / 60);
        int seconds = Mathf.FloorToInt(timeMatch % 60);
        
        textTimer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
