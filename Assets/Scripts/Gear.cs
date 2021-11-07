using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite sprite;


    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if(sprite != null)
            spriteRenderer.sprite = sprite;
    }
}