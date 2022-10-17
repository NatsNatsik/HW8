using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add: MonoBehaviour
{
    public Transform transform1;
    public Transform transform2;
    public Transform transform3;
   
    void Update()
    {
        transform.position = transform1.position + transform2.position+ transform3.position;
    }
}
