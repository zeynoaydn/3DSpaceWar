using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitSceneScript : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
