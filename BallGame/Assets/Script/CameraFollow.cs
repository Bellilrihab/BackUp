﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
  

   
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z-24f);
    }
}
