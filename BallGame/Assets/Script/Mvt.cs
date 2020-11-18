using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvt : MonoBehaviour
{
    public float speed =400;
    Rigidbody rb;
    public GameObject rightside, leftside;
    bool SwitchPos;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            if (SwitchPos == false)
            {
                SwitchPos = true;
                transform.position = new Vector3(rightside.transform.position.x, transform.position.y, transform.position.z);
            }
        }


        if (Input.GetKey("q"))

        {
            if (SwitchPos == true)
            {
                SwitchPos = false;

                transform.position = new Vector3(leftside.transform.position.x, transform.position.y, transform.position.z);

            }
        }



    }
}



