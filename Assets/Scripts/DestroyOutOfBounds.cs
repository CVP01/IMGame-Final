using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float Bound = -10;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (transform.position.z < Bound)
        {
            Destroy(gameObject);
            
        }
    }
}
