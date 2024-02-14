using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlanet : MonoBehaviour
{
    public int gezegenSayisi;
    public List<GameObject> myList = new List<GameObject>();
    void Start()
    {
        for(int i=0;i<gezegenSayisi;i++)
        {
            int sayi = Random.Range(0,myList.Count);
            GameObject planet = Instantiate(myList[sayi]);
          

            float randomx = Random.Range(-2000, 2000.0f);
            float randomy = Random.Range(-2000, 2000.0f);
            float randomz = Random.Range(-2000, 2000.0f);


            planet.transform.position= new Vector3(randomx, randomy, randomz);
            planet.transform.localScale= new Vector3(10,10,10);

            //Rigidbody rb=planet.AddComponent<Rigidbody>();
            //if(rb == null )
            //{
            //    rb=planet.AddComponent<Rigidbody>();
            //}
            //rb.useGravity = false;
            //planet.AddComponent<SphereCollider>();
            //planet.AddComponent<olduronu>();
            
        }
    }

    void Update()
    {
        
    }
}
