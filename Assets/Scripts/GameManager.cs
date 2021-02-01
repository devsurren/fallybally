using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float pos;
    [SerializeField]
    float levelDown;
    public GameObject pole;
    public GameObject mainMenuPanel;

    private GameObject instanceofMainMenuPanel;
    public bool isGameStarted;

    public static GameManager instance {get;set;}
   void Awake(){ instance=this;  }
    void Start()
    {
        initialPoles();
        instanceofMainMenuPanel=mainMenuPanel;
        isGameStarted=false;
    }

    void Update(){
        if(isGameStarted){ startGame();}
    }

    void initialPoles(){
        for(var i=0;i<3;i++){
            Vector3 onTarget=new Vector3(pole.transform.position.x,pos,pole.transform.position.z);
            Instantiate(pole,onTarget,Quaternion.identity);
            pos-=levelDown;
        }
    }

    public void startGame(){
       // SceneManager.LoadScene("Game");
        instanceofMainMenuPanel.SetActive(false);
    }
}
