using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{


    public CharacterController Character;
    public Vector3 spawnPoint ;



    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        spawnPoint = new Vector3(0, 0, 0);

      
        
        
        //Character.Move(transform.position);
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
