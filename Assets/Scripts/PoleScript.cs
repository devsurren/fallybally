using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleScript : MonoBehaviour
{
    [SerializeField]
     float rotationSpeed;
     float onLevelDown;

     public GameObject pole;

    void Start()
    {
        initialPoles();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,transform.position.y*rotationSpeed,0));
    }

    void initialPoles(){
        for(var i=0;i<3;i++){
            Vector3 onTarget = new Vector3(transform.position.x,transform.position.y-onLevelDown,transform.position.z);
            Instantiate(pole,onTarget,Quaternion.identity);
            onLevelDown=5f;

        }
    }
}
