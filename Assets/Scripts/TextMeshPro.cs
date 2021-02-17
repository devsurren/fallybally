using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshPro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject,20f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f,0.5f*Time.deltaTime,0));
    }
}
