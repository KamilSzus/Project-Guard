using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HideAllButton : MonoBehaviour
{
    public static bool isPaused = false;
    public List<GameObject> listOfButtons = new List<GameObject>();
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        foreach (var button in listOfButtons)
        {
            button.SetActive(isPaused);
        }
        isPaused = false;
    }

    public void PauseGame()
    {
        foreach (var button in listOfButtons)
        {
            button.SetActive(isPaused);
        }
        isPaused = true;
    }
}
