using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    [SerializeField] BoxCollider2D myBoxCollider;

    private void Start()
    {
        myBoxCollider = GetComponent<BoxCollider2D>();
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            myBoxCollider.enabled = true;
        }
    }
}


