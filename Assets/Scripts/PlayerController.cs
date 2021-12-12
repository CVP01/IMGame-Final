using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed= 9.0f;
    private float horizontalInput;
    public float xRange = 18;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     horizontalInput = Input.GetAxis("Horizontal");
     transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
