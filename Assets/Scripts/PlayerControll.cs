using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    float tapForce;
    Rigidbody rb;
   void Awake(){
       rb=GetComponent<Rigidbody>();
   }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.AddForce(Vector3.up * tapForce,ForceMode.Impulse);
        }
    }
}
