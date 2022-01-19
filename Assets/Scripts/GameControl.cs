using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Player player;

    public float resetTime = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holding == false)
        {
            resetTime -= Time.deltaTime;
            if (resetTime <= 0)
            {
                SceneManager.LoadScene("sccene1");
            }
        }
    }
}
