using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pew : MonoBehaviour
{

    public GameObject prefab;

   // public float force = 0;

    public Vector3 shootDirection;

   

    public void Start()
    {
         
       
        if (Input.GetKey(KeyCode.A))

        {
            // var forceDirection = new Vector3(0, 0, 0);


         prefab =  GetComponent<GameObject>();

            var forceDirection = new Vector3(0,1,0);
        }
    }
}

