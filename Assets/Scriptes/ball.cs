using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
	public Rigidbody rb;
	public float force;
	private int rnd;
	public KeyCode launchKey;
	public score Score;

    // Start is called before the first frame update
    void Start()
    {
    	
    }

   public void launch(){

    	rnd = Random.Range(0,2);
    	rb.velocity = new Vector3(0f,0f,0f);

    	if(Input.GetKey(launchKey)&Score.isFinished==false){

    	     if(rnd==0)
    	     rb.velocity=new Vector3(force,0f,force);
             else
             rb.velocity=new Vector3(-force,0f,-force);
    	}
    }

    
    // Update is called once per frame
    void Update()
    {
    	if(rb.velocity.x==0)
        launch();
    }
}
