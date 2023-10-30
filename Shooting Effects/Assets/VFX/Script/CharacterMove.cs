using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    // speed in which the character goes
    //character in question




    public Vector3 direction;
    public float f = 30f;
    public int speed;
    public CharacterController Character;

    public float gravity;
    //what do we need to activate at the start of the script 
    //starting with the character


    void Start()
    {
      Character = GetComponent<CharacterController>();


    }

    //what the character can do over time and what triggers the character to do those things

    void Update()
    {




     var hAxis = Input.GetAxis("Horizontal");

     var vAxis = Input.GetAxis("Vertical");   
        
        Vector3 move = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;
        Character.Move(transform.position = move);

        if(Input.GetKey(KeyCode.Q))

        {
            Vector3 direction = new Vector3(0, 1, 0) * gravity * Time.deltaTime;

         //(transform.position = direction);


        }

        // var vAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

    }
}
