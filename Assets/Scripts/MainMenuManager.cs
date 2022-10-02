using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject HTPCanvas;
    [SerializeField] private GameObject mainCanvas;

    public void ShowHTPScreen()
    {
        HTPCanvas.SetActive(true);
    }

    public void HideMainCanvas()
    {
        mainCanvas.SetActive(false);
    }

    public void HideHTPScreen()
    {
        HTPCanvas.SetActive(false);
    }

    public void ShowMainCanvas()
    {
        mainCanvas.SetActive(true);
    }


    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
}
