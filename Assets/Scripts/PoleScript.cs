using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleScript : MonoBehaviour
{
    [SerializeField]
     float rotationSpeed;
     
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,rotationSpeed,0));
    }

   
}
