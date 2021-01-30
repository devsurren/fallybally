using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

public static ScoreManager instance {get;set;}
public Text scorePanel;
public int score;
void Awake(){instance=this;}

void Start(){score=0;}

void Update(){
   scorePanel.text=score.ToString();
}

}
