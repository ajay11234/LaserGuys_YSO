using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_door : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DoorRight;
    public GameObject delete;
    public float pos;
     public spawn_enemies spawn;

     private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
     	spawn.LayerCollide3();

     	DoorRight.transform.position = new Vector3(DoorRight.transform.position.x + pos, DoorRight.transform.position.y, DoorRight.transform.position.z);

     	Destroy(delete);
        }
        
     }
}
