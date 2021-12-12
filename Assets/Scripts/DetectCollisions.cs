using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void Update()
    {
 
    }


    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.12f;
        Debug.Log("Game Over!");
        gameManager.GameOver();
        //gameManager.MainMenu()

    }
}
