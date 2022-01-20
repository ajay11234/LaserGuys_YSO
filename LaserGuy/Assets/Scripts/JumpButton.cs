using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    // Start is called before the first frame update
    public MovementManager movementManager;
    public int jumpForce;
   
   public void Jump(){
        
       if(movementManager.isGrounded){
    		movementManager.rb.AddForce(0,jumpForce,0);
    		movementManager.isGrounded = false;
    	}	

    }
}

   

