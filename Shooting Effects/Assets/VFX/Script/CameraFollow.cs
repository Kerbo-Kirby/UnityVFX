using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


  

    public Vector3 look;

    public Transform playr;


    public Camera came;

    

    // Start is called before the first frame update
    void Start()
    {

        
    }


    // Update is called once per frame
    void Update()
    {

        //transform.TransformDirection(look);


        transform.LookAt(playr);


    }
}

