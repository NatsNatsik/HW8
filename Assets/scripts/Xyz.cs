using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xyz : MonoBehaviour
{

    public Vector3 RotationVelocity;

  
    void Update()
    {
        transform.Rotate ( RotationVelocity * Time.deltaTime);
    }
}
