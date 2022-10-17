using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subtraction : MonoBehaviour
{
    public Transform position1;
    public Transform position2;
    public Transform position3;
  
    void Update()
    {
        transform.position = position1.position - position2.position - position3.position;
    }
}
