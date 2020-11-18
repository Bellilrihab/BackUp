using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Mvt BallMvt;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball")
        {
            Debug.Log("GameOver");

            BallMvt.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
