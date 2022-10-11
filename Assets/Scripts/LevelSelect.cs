using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("UI");
    }

    public void firstLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void secondLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
    
    public void thirdLevel()
    {
        SceneManager.LoadScene("Level 3");
    }
}
