using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplication : MonoBehaviour
{
    public Transform position1;
    public float Number;
   
    void Update()
    {
        transform.position = position1.position * Number;
    }
}
