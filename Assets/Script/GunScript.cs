using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public AudioClip audioClip;
    public GameObject bullet;
    public Transform gun;
   
    void Start()
    {
    }
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            atesEt();
   

        }
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.V))
        {
            atesEt();
          

        }
    }
     void atesEt()
    {
        GameObject mermi = Instantiate(bullet);
        mermi.transform.position = gun.position;
        mermi.transform.rotation = transform.parent.rotation * mermi.transform.rotation;
        //mermi.transform.localScale = new Vector3(2, 4, 2);

        Rigidbody rb = mermi.AddComponent<Rigidbody>();
        rb.AddForce(gun.forward * 10000.0f, ForceMode.Force);
        //Collider collider = mermi.AddComponent<Collider>();
        AudioSource audioSource = mermi.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();

    
        
    }
    void mermiclear()
    {
       
    }
   
}
