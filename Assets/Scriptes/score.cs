using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
	public int Score;
    public Text scoreText;
    public  int pcScore;
	public  int playerScore;
	public Text pcScoreText;
	public Text playerScoreText;
	public Text msg;
	public Text finalScore;
	public Text highScore;
	public bool isFinished;
	public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	scoreText.text=Score.ToString();

        
    }

    public void UI(){
    	pcScoreText.text=pcScore.ToString();
    	playerScoreText.text=playerScore.ToString();
    	
    	if(playerScore==3){
    		msg.text="YOU WIN";
    		finish();

    	}
    	if(pcScore==3){
    		msg.text="GAME OVER";
    		finish();
    	}

    }

    void finish(){
    	isFinished=true;

    	if(Score>PlayerPrefs.GetInt("score")){
    		PlayerPrefs.SetInt("score",Score);
    	}

    	panel.gameObject.SetActive(true);
    	finalScore.text =Score.ToString();
    	highScore.text=PlayerPrefs.GetInt("score").ToString();;
    	
    }

    public void restartbutton()
       {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }
}
