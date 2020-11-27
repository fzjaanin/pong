using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	public Rigidbody rb;
	public float force;
	public KeyCode right;
	public KeyCode left;
    public score score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(score.isFinished==false){
       if(Input.GetKey(left)){
        	rb.AddForce(-force*Time.deltaTime, 0, 0, ForceMode.Impulse);
           

        }

         if(Input.GetKey(right)){
        	rb.AddForce(force*Time.deltaTime, 0, 0, ForceMode.Impulse);
            
            

        }
    
    }
    }

   

}
