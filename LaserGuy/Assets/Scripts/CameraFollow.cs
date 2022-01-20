using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    
    void Start()
    {   int level = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(level);
    }

    void FixedUpdate(){

    	   Vector3 desiredPosition = target.position + offset;
    	   Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
           transform.position = smoothedPosition;
    }


    void Awake ()
{
  if (FB.IsInitialized) {
    FB.ActivateApp();
  } else {
    //Handle FB.Init
    FB.Init( () => {
      FB.ActivateApp();
    });
  }
}


}
