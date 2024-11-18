using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // Floats, variables etc.
    
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the Vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Allow the car to move side to side.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
