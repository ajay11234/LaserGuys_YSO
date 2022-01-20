using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_UI : MonoBehaviour
{
  public GameObject arrow_pad;

  private Touch touch;
  private Vector2 beginTouchPosition;

    void Start()
    {
    	
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.touchCount > 0){
    		touch = Input.GetTouch(0);
    		switch (touch.phase){
    			case TouchPhase.Began:
    			beginTouchPosition = touch.position;
    			Debug.Log("Lalla");
    			break;
    		}
    	}

 	}
  
     


}
