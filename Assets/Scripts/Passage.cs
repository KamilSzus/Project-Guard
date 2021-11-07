// Mateusz Kapka 02.11.2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passage : MonoBehaviour
{
    // Passage script add as Component to Canvas and as a Text Game Object set TextGameObject
    // To create TextGameObject create Create Empty in Canvas and set tag stamp
    private PersonInfo info;
    private GameObject stamp;
    public Passage(PersonInfo info)
    {
        this.info = info;
    }

    void Update()
    {
        stamp = GameObject.FindGameObjectWithTag("stamp"); // tag in TextGameObject

        if (stamp != null)
        {
            Text textObject = stamp.GetComponent<Text>(); //get the text component in the gameobject you assigned
            textObject.text = "insert here text"; //set the text in the text component
        }
    }
}
