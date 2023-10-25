using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cursor = UnityEngine.Cursor;
using UnityEngine.Events;

public class pew : MonoBehaviour
{

    public GameObject prefab;

    public float force = 30f;

    public Vector3 shootDirection;

    public Vector3  gravity;

    public void Start()
    {
         

        if (Input.GetKey(KeyCode.A))

        {
           // var forceDirection = new Vector3(0, 0, 0);

            GetComponent<GameObject>();

            //var forceDirection = new Vector3(force, 0, 0);
        }
    }
}

