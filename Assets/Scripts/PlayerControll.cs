using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    float tapForce;
    public Color[] colors;
    private string currentColor;
    Rigidbody rb;
    Renderer render;
   void Awake(){
       rb=GetComponent<Rigidbody>();
       render=GetComponent<Renderer>();
   }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.AddForce(Vector3.up * tapForce,ForceMode.Impulse);
        }
    }
    void randomizePlayerColor(){
        //B;L;P;R
        int colornumber = Random.Range(0,colors.Length);
        switch(colornumber){
            case 0:
                render.material.color=colors[0];
                currentColor="Blue";
                break;
            case 1:
                render.material.color=colors[1];
                currentColor="Lime";
                break;
            case 2:
                render.material.color=colors[2];
                currentColor="Purple";
                break;
            case 3:
                render.material.color=colors[3];
                currentColor="Red";
                break;
            default:
                render.material.color=colors[0];
                currentColor="Blue";
                break;

        }

    }
}
