using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScen : MonoBehaviour
{
    static public List<string> scenLoader = new List<string> {"Level2", "Level3" };

    public void loadScene()
    {
        string scanName = scenLoader[Random.Range(0, scenLoader.Count)];
        scenLoader.Remove(scanName);
        SceneManager.LoadScene(scanName);
    }

    
}
