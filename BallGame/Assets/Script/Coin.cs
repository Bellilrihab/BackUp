using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinprefab;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Destroy(gameObject);
            Debug.Log("you took the coin");
        }

    }
}
