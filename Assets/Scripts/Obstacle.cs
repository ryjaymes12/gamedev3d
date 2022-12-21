using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
 
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter (Collision collision1)
    {
        if (collision1.gameObject.name == "Player")
        {
            playerMovement.end();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
