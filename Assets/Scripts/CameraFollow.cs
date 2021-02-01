using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 deltaDistance;
    void LateUpdate()
    {
        if(player){
           Vector3 targetLoaction = player.position+deltaDistance;
           transform.position=targetLoaction;
        }
    }
}
