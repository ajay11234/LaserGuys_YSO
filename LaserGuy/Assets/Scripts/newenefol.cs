using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newenefol : MonoBehaviour
{
     public GameObject enemy;

   bool isDone = false;
   public float speed;
   int your_int = 15; 
   public Color mycolor;
   public Color Color;

   int hit = 0;

   public GameObject player;
  // public ParticleSystem blood;

   public spawn_enemies spawn;

void HitByRay () {
         //Debug.Log ("I was hit by a Ray");
     }

     void start(){
          //enemy.transform.rotation = Quaternion.Euler(90, 90, 90);
     }

     void Update()
    {
        //Invoke("Action", 1.0f);
      Action();
    }

     void Action(){
          //
        //enemy.active = true;
        //enemy.transform.LookAt(player.transform);
       // enemy.transform.rotation = Quaternion.Euler(90, 90, 90);
      //enemy.transform.rotation = Quaternion.Euler(0, 90, 0);
        //transform.position += enemy.transform.forward * speed * Time.deltaTime;

     }

     public void changeColor(){
     	  enemy.GetComponent<Renderer> ().material.color = mycolor;
            enemy.GetComponent<Renderer> ().material.SetColor("_EmissionColor", Color);

     }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cutter"){
               //spawn.HitEvent();
          //hit += 1;
          //Debug.Log(hit);
         // blood.Play();
        	changeColor();
        	//Invoke("changeColor",0.5f);
          
        }

    }
    
}
