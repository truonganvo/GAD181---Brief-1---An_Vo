using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown10Sec : MonoBehaviour
{
    public float currentTime;

    public TextMeshProUGUI countDownText;

    private void Start()
    {
        currentTime = 10f;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentTime = 10f;
        }
    }
}

