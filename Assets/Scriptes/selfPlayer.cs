using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfPlayer : MonoBehaviour
{
	public GameObject ball;
	public float min;
	public float max;
	public float offset;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
    	//if(ball.transform.position.z>=0){
    		if(ball.transform.position.x>=min & ball.transform.position.x<=max)
            transform.position = new Vector3(ball.transform.position.x*offset,transform.position.y, transform.position.z);
         //}

    }
}
