using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
//using GameAnalyticsSDK;

public class rotating : MonoBehaviour
{
    public Joystick joystick;
    public float rotateVertical;
    public float rotateHorizontal;
    public float height;
    public Rigidbody rb;
    public float movementSpeed = -100f;


    public float speed = 12.0f;

    RaycastHit hit;

    public static bool isTouching;

    public static rotating instance;


    // private void Awake(){
    // 	//instance = this;
    // 	//DontDestroyOnLoad(this);

    // }




    void Start(){
         //Debug.Log("Initialize");
         rb = GetComponent<Rigidbody>();
       // GameAnalytics.Initialize();

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

    void  FixedUpdate(){

           // Debug.Log(joystick);

            rotateVertical = joystick.Vertical * 2f;
            rotateHorizontal = joystick.Horizontal * 2f;

            //Debug.Log(joystick.Vertical);

            if(joystick.Vertical == 0){

                //Debug.Log("Dynamic");
               rb.useGravity = true;

                isTouching = false;

            }else if(joystick.Vertical > 0 || joystick.Vertical < 0){
                 rb.useGravity = false;
                 //Debug.Log("Kinematic");

                 isTouching = true;
            }
            
            //RayCast
            Ray ray = new Ray(transform.position, -Vector3.up);
            Debug.DrawRay(transform.position, -transform.up * 10,Color.red);
            //RayCast
            
            //Raycast//
            if (Physics.Raycast(ray, out hit)){
                if(hit.collider.tag == "ground"){
                   // Debug.Log(hit.collider.name);
                }
            }
            //RayCast//
           
           Vector3 moveVector = new Vector3(joystick.Horizontal, joystick.Vertical, 0f);
           // Vector3 moveVector = new Vector3(0f, joystick.Vertical, joystick.Horizontal);
           // Vector3 moveVector = new Vector3(0f, joystick.Vertical, joystick.Horizontal);

            if (moveVector == Vector3.zero)
        {
            return;
        }
           



            Quaternion targetRotation = Quaternion.LookRotation(moveVector);
            
            //targetRotation = Quaternion.RotateTowards(
            //transform.rotation,
            //targetRotation,
           // 360 * Time.fixedDeltaTime);

           // rb.MovePosition(rb.position + moveVector * speed * Time.fixedDeltaTime);
          //rb.MoveRotation(targetRotation);


            transform.Rotate(0,0,rotateHorizontal);
           // transform.Rotate(0,0,rotateVertical);
    }

     
  }


