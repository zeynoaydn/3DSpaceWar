using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueSceneScript : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Continue()
    {
        canvas.SetActive(true);
        Time.timeScale = 1f;
    }

}