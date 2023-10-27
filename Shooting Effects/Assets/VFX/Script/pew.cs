using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class pew : MonoBehaviour
{
    private Rigidbody rBody;
    public float force = 30f;
    public VectorShoot shoot;
    public void Start()
    {

        if (Input.GetKey(KeyCode.Mouse0))

            rBody = GetComponent<Rigidbody>();



        //var forceDirection = new Vector3(force, 0, 0);
        rBody.AddRelativeForce(shoot.value * force);




    }
}

