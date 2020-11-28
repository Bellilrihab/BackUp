using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideStreetSpawner : MonoBehaviour
{
   
    private float SideroadSize=-19.7f;
    private float XPosR= 108.1f;
    private float XPosL=-50.5f;
    private float PreviouszPos= 291f;
   
    
   private readonly int IniSideRoadAmount = 1;
    public List<GameObject> SideStreet;
    void Start()
    {
       for(int i=0; i <IniSideRoadAmount;i++)
        {
           
            GameObject LeftSideSt=SideStreet[Random.Range(0,SideStreet.Count)];
            GameObject RightSideSt = SideStreet[Random.Range(0, SideStreet.Count)];
            float Zpos = PreviouszPos+ SideroadSize;
        
            Instantiate(LeftSideSt, new Vector3(XPosL, -8.6f, Zpos), LeftSideSt.transform.rotation);
            Instantiate(RightSideSt, new Vector3(XPosR, -8.6f, Zpos), RightSideSt.transform.rotation);
            PreviouszPos+= SideroadSize;
        

        }
    }

   
    void Update()
    {
        
    }
}
