using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoors : MonoBehaviour
{
  
   private float movementSpeed = 5f;
   public GameObject DoorLeft;
   public GameObject DoorRight;
   public GameObject DoorTrigger;
   public float pos;
   public spawn_enemies spawn;

   public bool Movement = false;

   void Update(){
       
       //if(Movement){
            //Vector3 newPos = new Vector3(DoorLeft.transform.position.x, DoorLeft.transform.position.y, DoorLeft.transform.position.z);
            //DoorLeft.transform.position =  newPos;
      // }

   }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
                     spawn.LayerCollide();
                //Endscrn.gameObject.SetActive(true);
               //Debug.Log("Movement to left");
        	     //transform.position = transform.position + new Vector3(movementSpeed, 0, 0);
               // Vector3 newPos = new Vector3(- 5,,DoorLeft.transform.position.z);
               DoorLeft.transform.position = new Vector3(DoorLeft.transform.position.x + pos, DoorLeft.transform.position.y, DoorLeft.transform.position.z);
               DoorRight.transform.position = new Vector3(DoorRight.transform.position.x - pos, DoorRight.transform.position.y, DoorRight.transform.position.z);

               Destroy(DoorTrigger);
              // Movement = true;
               //DoorLeft.GetComponent<Rigidbody>().AddForce(10, 10, 10);
              

        }

    }

}
