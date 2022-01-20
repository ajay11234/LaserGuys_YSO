using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class EnemyFollow : MonoBehaviour
{
   
   public GameObject enemy;

   bool isDone = false;
   public float speed;
   int your_int = 15; 
   public Color mycolor;
   public Color Color;

   public GameObject player;

   public spawn_enemies spawn;
   int ft = 0;

void HitByRay () {
         //Debug.Log ("I was hit by a Ray");
     }

     void Update()
    {
        //Invoke("Action", 1.0f);
      Action();
    }

     void Action(){
        //enemy.active = true;
        transform.LookAt(player.transform);
        transform.position += enemy.transform.forward * speed * Time.deltaTime;

     }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cutter"){
              ft += 1;
              //Debug.Log(ft);
               spawn.HitEvent();
            enemy.GetComponent<Renderer> ().material.color = mycolor;
            enemy.GetComponent<Renderer> ().material.SetColor("_EmissionColor", Color);

        }

    }
    



}
