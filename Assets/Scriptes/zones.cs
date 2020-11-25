using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zones : MonoBehaviour
{
	public GameObject ball;
	public string playerName;
	public score Score;



    void OnTriggerEnter(Collider collider){

    	if(collider.tag=="ball"){
    		ball.transform.position = new Vector3(0f, 0.308f ,-0.096f);
    		ball.GetComponent<ball>().launch();
    		if(playerName=="player"){
    			Score.pcScore++;
    			Score.GUI();


    		}
    		else if(playerName=="pc"){
    			Score.playerScore++; 
    			Score.GUI();

    		}
    		
    	}
    }

   

}