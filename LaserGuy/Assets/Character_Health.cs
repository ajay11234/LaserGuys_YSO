using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Health : MonoBehaviour
{
    // Start is called before the first frame update
    public float Dec_Health = 0f;
    public Healthbar healthbar;
    public GameObject gameover;
    float healthloss;
    public GameObject leftarm;
    public GameObject Laser;
    void Start()
    {
        //healthbar.UpdateHealth((float)0.5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy"){
        	     //Debug.Log("Enemy");
 				Dec_Health += 0.06f;
                 healthloss = 1f - Dec_Health;
        	     healthbar.UpdateHealth(healthloss);
                 if(healthloss <= 0){
                    leftarm.SetActive(false);
                    gameover.SetActive(true);
                 }    
        }

        if(other.gameObject.tag == "ground"){
                //Laser.active = false;
        }

    }
}
