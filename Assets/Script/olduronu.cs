using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class olduronu : MonoBehaviour
{
    float maxCan = 9.0f;
    float can;
    public Slider slider;
    void Start()
    {
        can = maxCan;
    }

    void Update()
    {
        if(slider != null)
        {
            slider.value = ((float)can / maxCan)/9.0f;
        }
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        if (collision.gameObject.name == "Mermi(Clone)")
        {
            maxCan--;
            if (maxCan <= 0)
            {
                Destroy(gameObject);

            }
        }
    }
    
}
