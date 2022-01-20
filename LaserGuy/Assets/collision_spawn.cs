using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_spawn : MonoBehaviour
{
    // Start is called before the first frame update
     public spawn_enemies spawn;
     public GameObject detroyself;
     
     private void OnTriggerEnter(Collider other){
     	if(other.tag == "Player"){
     	spawn.LayerCollide2();
     	Destroy(detroyself);
       }
     }
}
