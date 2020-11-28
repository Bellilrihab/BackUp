using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private const bool V = false;
   public Mvt BallMvt;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball")
        {
            Debug.Log("GameOver");

            BallMvt.enabled = V;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
