using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Traps : MonoBehaviour
{
    public GameObject Camera;
    [SerializeField] GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOverScene");
            Camera.GetComponent<CameraController>().enabled = false;
        }
    }
}
