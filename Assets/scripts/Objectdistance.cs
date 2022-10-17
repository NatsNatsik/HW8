using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectdistance : MonoBehaviour
{
    public Transform position1;
    public Transform position2;
          
   
    void Update()
    {
        transform.position = new Vector3(0, Vector3.Distance(position1.position, position2.position), 0);
        

    }
}
