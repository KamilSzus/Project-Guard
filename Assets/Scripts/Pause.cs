using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void backToMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
