using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 30;
    float val=1;

    private int rnd;
    public KeyCode launchKey;
    public score score;

  
    
    float findX(Vector3 ballPos, Vector3 paddlePos,
                    float paddleHeight) {
       
        return (ballPos.x - paddlePos.x) / paddleHeight;
    }

    void OnCollisionEnter(Collision col) {
    
        if (col.gameObject.name == "player") {
            
            float x = findX(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.x);

            
            Vector3 dir = new Vector3(x, 0f, 1).normalized;
            GetComponent<Rigidbody>().velocity = dir * speed;
            val=1;

            score.Score+=5;
        }

       
         if (col.gameObject.name == "paddle2") {
            
            float x = findX(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.x);

          
            Vector3 dir = new Vector3(x,0f , -1).normalized;
 
            GetComponent<Rigidbody>().velocity = dir * speed;
            val=-1;
        }

        if(col.gameObject.name == "wallLeft"){
            Vector3 dir = new Vector3(1f,0f , val).normalized;
      
            GetComponent<Rigidbody>().velocity = dir * speed;

        }
             
             
        

        if(col.gameObject.name == "wallRight"){
            Vector3 dir = new Vector3(-1f,0f , val).normalized;
            
            GetComponent<Rigidbody>().velocity = dir * speed;
        }       
        
    }

       public void launch(){

        rnd = Random.Range(0,2);
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if(Input.GetKey(launchKey)&score.isFinished==false){

             if(rnd==0)
             GetComponent<Rigidbody>().velocity = new Vector3(0.5f, 0f, 1f) * speed;
             else
             GetComponent<Rigidbody>().velocity = new Vector3(0.5f, 0f, -1f) * speed;
        }
    }

     void Update()
    {
        if(GetComponent<Rigidbody>().velocity.x==0)
        launch();
    }
}
