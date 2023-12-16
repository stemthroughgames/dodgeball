using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody my_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if a key is pressed, if so move the player
        if (Input.GetKey("left") ||Input.GetKey("right") || Input.GetKey("up") || Input.GetKey("down")){
            //Vector3 is the position on the 3D space (x,y,z)
            Vector3 my_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            my_Rigidbody.MovePosition(transform.position + my_Input * Time.deltaTime * 10f);
        }
    }
}
