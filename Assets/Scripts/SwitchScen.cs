using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScen : MonoBehaviour
{
    static public List<string> scenLoader = new List<string> {"Level2", "Level3", "Wrzód", "Level4", "Level5", "Level6", "Level7", "Level8", "Level9", "Level10" };

    public void loadScene()
    {
        if (scenLoader.Count != 0)
        {
            string scanName = scenLoader[Random.Range(0, scenLoader.Count)];
            if (!scanName.Equals("Wrzód") || scenLoader.Count == 1)
            {
                scenLoader.Remove(scanName);

            }
            SceneManager.LoadScene(scanName);
        }
        else
        {
            var dict = new Dictionary<string, int>();

            dict.Add("loyalty", ScoreVariable.loyalty);
            dict.Add("morality", ScoreVariable.morality);
            dict.Add("evil", ScoreVariable.evil);
            dict.Add("greed", ScoreVariable.greed);


            var keyOfMaxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            if (keyOfMaxValue == "loyalty")
            {
                //SceneManager.LoadScene("loyaltyEnd");
                Debug.Log("loyaltyEnd");
            }
            else if (keyOfMaxValue == "morality")
            {
                //SceneManager.LoadScene("moralityEnd");
                Debug.Log("moralityEnd");
            }
            else if (keyOfMaxValue == "evil")
            {
                //SceneManager.LoadScene("evilEnd");
                Debug.Log("evilEnd");
            }
            else
            {
                //SceneManager.LoadScene("greedEnd");
                Debug.Log("greedEnd");
            }

        }
    }
    public void deathEnd()
    {
        //SceneManager.LoadScene("deathEnd");
        Debug.Log("deathEnd");
    }

    public void zabijWrzoda()
    {
        scenLoader.Remove("Wrzód");
        loadScene();
    }
    
}
