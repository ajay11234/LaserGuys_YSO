using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedoor2 : MonoBehaviour
{
    public GameObject DoorRight;
    public GameObject delete;
    public float pos;
     public spawn_enemies spawn;

     private void OnTriggerEnter(Collider other){
     	if(other.gameObject.tag == "Player"){
     	spawn.LayerCollide();

     	DoorRight.transform.position = new Vector3(DoorRight.transform.position.x + pos, DoorRight.transform.position.y, DoorRight.transform.position.z);

     	Destroy(delete);
     	}
     }
}
