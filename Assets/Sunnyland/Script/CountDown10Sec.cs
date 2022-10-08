using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown10Sec : MonoBehaviour
{
    public float currentTime;

    public TextMeshProUGUI countDownText;
    public Image timerImage;
    public float maxTime = 10f;

    private void Start()
    {
        currentTime = 10f;
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0"); //.ToString help convert number to string/

        timerImage.fillAmount = currentTime / maxTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Restart");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentTime = 10f;
        }
    }
}

