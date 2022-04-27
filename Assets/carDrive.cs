// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class carDrive : MonoBehaviour
{
    public float speed = 50f;
    public float turnSpeed = 10f;
    private Rigidbody rb;
    public float gravityMul = 9.80f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       move();
       turn();
       fall();   
       
    }
    void move(){
        if(Input.GetKey(KeyCode.W)){ 

            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed);
                   // rb.velocity = new Vector3(0f, 0f, speed * Time.deltaTime);

        }
        else if(Input.GetKey(KeyCode.S)){

            rb.AddRelativeForce(- new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed);
                   // rb.velocity = new Vector3(0f, 0f, speed * Time.deltaTime);

        }
        // Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        // localVelocity.x = 0;
        // rb.velocity = transform.TransformDirection(localVelocity);
    }
     void turn(){
          if(Input.GetKey(KeyCode.D)){

            rb.AddTorque(Vector3.up * turnSpeed * 0.4f);
        }
         else if(Input.GetKey(KeyCode.A)){

            rb.AddTorque(-Vector3.up * turnSpeed * 0.4f);
        }
        
    } void fall(){
        rb.AddForce(Vector3.down *gravityMul);

    }
}
