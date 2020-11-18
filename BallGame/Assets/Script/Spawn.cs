using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Road;
    private float nextspawnpos = 0;
    private int RoadNum = 3;
    public  float RoadLength=100f;
    private List<GameObject> Roads = new List<GameObject>();
    public  Transform Ball;


    void Start()
    {
       for (int i = 0; i < RoadNum; i++)
        {
            RoadSpawner(Random.Range(0, Road.Length));
        }
    }
    void Update()
    {
        if(Ball.position.z -87 > nextspawnpos-(RoadNum*RoadLength))
        {
            RoadSpawner(Random.Range(0, Road.Length));
            RemoveRoad();
        }


    }
    void RoadSpawner(int roadindex)
    {
       GameObject obj= Instantiate(Road[roadindex], transform.forward * nextspawnpos,transform.rotation);
        nextspawnpos += RoadLength;
        Roads.Add(obj);
    }
    void RemoveRoad()
    {
        Destroy(Roads[0]);
        Roads.RemoveAt(0);  //remove from the list
    }
  
}
