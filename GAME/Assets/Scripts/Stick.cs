using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    PlayerControllerX playerControllerX;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerX = GameObject.FindObjectOfType<PlayerControllerX>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerControllerX.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
