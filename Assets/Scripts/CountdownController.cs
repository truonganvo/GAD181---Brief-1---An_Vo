using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public float timeRemaining = 3;
    public bool timerIsRunning = false;
    public TextMeshProUGUI countdownDisplay;

    private void Start()
    {
        timerIsRunning = true;
    }

    public void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;

        }
    }



    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

}

