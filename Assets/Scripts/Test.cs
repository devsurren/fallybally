using UnityEngine;

public class Test : MonoBehaviour
{
   public GameObject ps;
    void Start()
    {
        testing();
        blowUp();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void testing(){
        print("Just Use This Script File for Your Testing");
    }

    void blowUp(){
      GameObject bs= Instantiate(ps,transform.position,Quaternion.identity) as GameObject;
     // bs.GetComponent<ParticleSystem>().startColor=Color.blue;
        
    }
}
