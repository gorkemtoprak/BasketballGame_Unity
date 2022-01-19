using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;

public class Score : MonoBehaviour
{
    public GameObject effect;

    private void Start()
    {
        effect.SetActive (false);
    }
    void OnTriggerEnter(Collider otherCollider)
    {
     if(otherCollider.GetComponent<Ball> () != null)
        {
            effect.SetActive(true);
        }  
    }

}
