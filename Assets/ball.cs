using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody ball_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ball_Rigidbody.AddForce(-transform.forward * 2500f);
    }

    // Detect if the collsion with the ball happened or not
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Cylinder"){
            print("You lose!");
        }
    }
}
