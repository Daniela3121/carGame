// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class camFollows : MonoBehaviour
{
    public float smoothing;
    public Transform player;
    public float roteSmoothing;

   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, smoothing);
        transform.rotation = Quaternion.Slerp(transform.rotation, player.rotation, roteSmoothing); 
        transform.rotation = Quaternion.Euler(new Vector3 (0, transform.rotation.eulerAngles.y, 0));

       
       
    }
}
