using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;

    public float throwForce = 5f;
    public bool holding = true;
    
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (holding)
        {
            ball.transform.position = player.transform.position + player.transform.forward * 2;

            if (Input.GetMouseButtonDown(0))
            {
                holding = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(player.transform.forward * throwForce);
            }
        }
        
        
    }
}
