using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class spawn_enemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    

    public GameObject player;
    public float speed;

    public GameObject DoorLeft;
   public GameObject DoorRight;
   public TextMeshProUGUI Text;
   public TextMeshProUGUI Text2;

   public float pos;
   int add = 0;
   public int Defeat;

   public float time1;
   public float time2;
   public float time3;
   public float time4;
   public float time5;
   public float time6;
   public float time7;
   public float time8;

   public int Defeat2;


    public Color mycolor;
   public Color Color;

    void Start()
    {


    //Invoke("Action1", time1);
    //Invoke("Action2", 1.2f);
    //Invoke("Action3", 1.4f);
    //Invoke("Action4", 2f);


        //Invoke("Action", 2.0f);
    }

   

    public void LayerCollide2(){
            Invoke("Action1", time1);
            Invoke("Action2", time2);
            Invoke("Action3", time3);
            Invoke("Action4", time4);
    }

    public void start_spawn(){
            Invoke("Action1", time1);
            Invoke("Action2", time2);
            Invoke("Action3", time3);
    }
    
    public void startspawn2(){
            Invoke("Action1", time1);
            Invoke("Action2", time2);
            Invoke("Action3", time3);
            Invoke("Action4", time4);
    }
   

    public void startspawn3(){

            Invoke("Action1", time1);
            Invoke("Action2", time2);
            Invoke("Action3", time3);
            Invoke("Action4", time4);
             Invoke("Action5", time5);
        Invoke("Action6", time6);
        Invoke("Action7", time7);
        Invoke("Action8", time8);

    }


    public void LayerCollide(){
            Invoke("Action4", time4);
            Invoke("Action5", time5);
            Invoke("Action6", time6);
            Invoke("Action7", time7);
            Invoke("Action8", time8);

    }

    public void LayerCollide3(){
        Invoke("Action5", time5);
        Invoke("Action6", time6);
        Invoke("Action7", time7);

    }

    public void LayerCollide4(){
        Invoke("Action4", time4);
        Invoke("Action5", time5);
        Invoke("Action6", time6);
        Invoke("Action7", time7);
        Invoke("Action8", time8);
    }

    void Action4(){
        enemy4.active = true;
     }

     void Action5(){
        enemy5.active = true;
     }

     void Action6(){
        enemy6.active = true;
     }

     void Action7(){
        enemy7.active = true;
     }
     void Action8(){
        enemy8.active = true;
     }


    void Action1(){
        enemy1.active = true;

     }
      void Action2(){
        enemy2.active = true;
      

     }
     void Action3(){
        enemy3.active = true;

     }



     public void HitEvent(){
       //Debug.Log(value);
        Defeat -= 1;
        
       //Debug.Log(Defeat);
        Text.text = "Total Enemies" +  Defeat.ToString();

        if(Defeat == 0){
          Text.enabled = false;
              DoorLeft.transform.position = new Vector3(DoorLeft.transform.position.x - (pos + 2.4f), DoorLeft.transform.position.y, DoorLeft.transform.position.z);
              DoorRight.transform.position = new Vector3(DoorRight.transform.position.x + pos, DoorRight.transform.position.y, DoorRight.transform.position.z);

        }







     }

     


}
