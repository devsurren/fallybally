﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    float tapForce;
    [SerializeField]
    float textUp;
    public Color[] colors;
    private string currentColor;
    private int colornumber;
    Rigidbody rb;
   MeshRenderer render;
   TrailRenderer tr;

    public GameObject blows;
    public GameObject textMeshpro;
    public Text scorePanel;
    private int tempScore;
   void Awake(){
       rb=GetComponent<Rigidbody>();
       render=GetComponent<MeshRenderer>();
       tr=GetComponent<TrailRenderer>();
   }
   void Start(){
       randomizePlayerColor();
       rb.useGravity=false;
   }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameManager.instance.isGameStarted=true;
            rb.useGravity=true;
            rb.AddForce(Vector3.up * tapForce,ForceMode.Impulse);
        }
    }
    void randomizePlayerColor(){
        //B;L;P;R
          colornumber = Random.Range(0,colors.Length);
        switch(colornumber){
            case 0:
                render.material.color=colors[0];
                tr.material.color=colors[0];
                currentColor="Blue";
                break;
            case 1:
                render.material.color=colors[1];
                tr.material.color=colors[1];
                currentColor="Lime";
                break;
            case 2:
                render.material.color=colors[2];
                  tr.material.color=colors[2];
                currentColor="Purple";
                break;
            case 3:
                render.material.color=colors[3];
                  tr.material.color=colors[3];
                currentColor="Red";
                break;
            default:
                render.material.color=colors[0];
                  tr.material.color=colors[0];
                currentColor="Purple";
                break;

        }

    }

   void OnCollisionEnter(Collision other){
       if(other.gameObject.tag==currentColor){
           ScoreManager.instance.score+=5;
          // textMeshpro.GetComponent<TextMesh>().color=colors[colornumber];
             Instantiate(textMeshpro,transform.position,Quaternion.identity);
          GameObject blast= Instantiate(blows,transform.position,Quaternion.identity)as GameObject;
        // ParticleSystem.MainModule setUp = blast.GetComponent<ParticleSystem>().main;
        // setUp.startColor= new ParticleSystem.MinMaxGradient(render.material.color);
        blast.GetComponent<ParticleSystem>().startColor=render.material.color;
           randomizePlayerColor();
            Destroy(other.gameObject);
          
       } else if(other.gameObject.tag!="Pole"&&other.gameObject.tag!=currentColor){
           GameManager.instance.isGameOver=true;
           rb.isKinematic=true;
           print("GameOver");
       }

       if(other.gameObject.tag=="Finish"){ 
           GameManager.instance.isLevelUp=true;
           rb.isKinematic=true;
           PlayerPrefs.SetInt("currentlevel",PlayerPrefs.GetInt("currentlevel")+1);
         }
   }
        
    
}
