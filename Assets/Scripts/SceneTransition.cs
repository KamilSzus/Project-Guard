using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Animator animation;
    private SwitchScen scenes;

    public void transtionToNextScene() {
        scenes = GetComponent<SwitchScen>();
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene() {
        animation.SetTrigger("SceneEnd");
        yield return new WaitForSeconds(1.5f);
        scenes.loadScene();
    }
}
