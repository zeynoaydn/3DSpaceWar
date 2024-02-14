using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform aracTransform;
    public GameObject prefab;
    public float hareketHizi = 5f;
    void Start()
    {
        Application.targetFrameRate = 200;
        aracTransform = prefab.transform;

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            aracTransform.Translate(aracTransform.forward * hareketHizi * Time.deltaTime,Space.World);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            aracTransform.Translate(-aracTransform.forward * hareketHizi * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            aracTransform.Rotate(Vector3.up, -0.25f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            aracTransform.Rotate(Vector3.up, 0.25f);
        }
        if (Input .GetKey(KeyCode.RightArrow))
        {
            aracTransform.Translate(aracTransform.right*hareketHizi*Time.deltaTime,Space.World);
            aracTransform.Rotate(Vector3.forward, -1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
             aracTransform.Translate(-aracTransform.right * hareketHizi * Time.deltaTime, Space.World);
             aracTransform.Rotate(Vector3.forward, 1);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            aracTransform.Rotate(Vector3.right, -1);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            aracTransform.Rotate(Vector3.left, -1);

        }
    }

}
