using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float pos;
    [SerializeField]
    float levelDown;
    public GameObject pole;
    // Start is called before the first frame update
    void Start()
    {
        initialPoles();
    }

    void initialPoles(){
        for(var i=0;i<3;i++){
            Vector3 onTarget=new Vector3(pole.transform.position.x,pos,pole.transform.position.z);
            Instantiate(pole,onTarget,Quaternion.identity);
            pos-=levelDown;
        }
    }
}
