using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float pos;
    [SerializeField]
    float levelDown;
    public GameObject pole;
    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;
    public GameObject levelUpPanel;
    public Transform player;
    public Transform finishLine;

    public Slider slider;
    public Text currentLevel;
    public Text nextLevel;

    private GameObject instanceofMainMenuPanel;
    private GameObject instanceofGameOverPanel;
    private GameObject instanceofLevelUpPanel;
    public bool isGameStarted;
    public bool isGameOver;
    public bool isLevelUp;

    public static GameManager instance {get;set;}
   void Awake(){ instance=this;  }
    void Start()
    {
        initialPoles();
        instanceofMainMenuPanel=mainMenuPanel;
        instanceofGameOverPanel=gameOverPanel;
        instanceofLevelUpPanel=levelUpPanel;
        currentLevel.text=(PlayerPrefs.GetInt("currentlevel")+1).ToString();
        nextLevel.text=(PlayerPrefs.GetInt("currentlevel")+2).ToString();
        isGameStarted=false;
    }

    void Update(){
       
        if(isGameStarted){ 
            startGame();
             slider.value=player.position.y/finishLine.position.y;
        }
        if(isGameOver){
            instanceofGameOverPanel.SetActive(true);
        }
        if(isLevelUp){ instanceofLevelUpPanel.SetActive(true);}
        
    }

    void initialPoles(){
        for(var i=0;i<3;i++){
            Vector3 onTarget=new Vector3(pole.transform.position.x,pos,pole.transform.position.z);
            Instantiate(pole,onTarget,Quaternion.identity);
            pos-=levelDown;
        }
    }

    public void startGame(){
        instanceofMainMenuPanel.SetActive(false);
    }

    public void restartGame(){
        SceneManager.LoadScene("Game");
    }

    public void levelupGame(){
        SceneManager.LoadScene("Game");
    }
}
