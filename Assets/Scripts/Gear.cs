using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite sprite;


    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material.renderQueue = 4000;
        GameObject button = GameObject.Find("ExitPassButton");
        if (button != null)
            button.SetActive(false);
        if(sprite != null)
            spriteRenderer.sprite = sprite;
    }
}