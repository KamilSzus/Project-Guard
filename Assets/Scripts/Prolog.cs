using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prolog : MonoBehaviour
{
    public float speed = 10;

    [System.Obsolete]
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);
        pos += localVectorUp * speed * Time.deltaTime;
        transform.position = pos;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("SampleScene");
        }
    }
}
