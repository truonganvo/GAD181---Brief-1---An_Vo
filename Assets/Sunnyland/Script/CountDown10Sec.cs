using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown10Sec : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;

    public TextMeshProUGUI countDownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0"); //.ToString help convert number to string/

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Restart");
        }
    }
}
