using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zones : MonoBehaviour
{
	public GameObject ball;
	public string playerName;
	public score score;



    void OnTriggerEnter(Collider collider){

    	if(collider.tag=="ball"){
    		ball.transform.position = new Vector3(0f, 0.308f ,-0.096f);
            ball.GetComponent<ball>().launch();
    		//ball.GetComponent<ball>().launch();
    		if(playerName=="player"){
    			score.pcScore++;
    			score.UI();


    		}
    		else if(playerName=="pc"){
    			score.playerScore++; 
    			score.UI();
                score.Score+=50;

    		}
    		
    	}
    }

   

}