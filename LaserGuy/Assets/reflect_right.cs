using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflect_right : MonoBehaviour
{
    public Rigidbody Gun;
    public float right;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
     	if(other.gameObject.tag == "ground"){
    		       Debug.Log("Passing Through");
                  

    	}

    }





}
