using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions1 : MonoBehaviour
{
 
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Final Release will have a Functional Fuel System
        // Debug.Log("Level Passed");
        //Destroy(gameObject);

        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(2);


    }
}
