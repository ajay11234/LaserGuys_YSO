using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect_back : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Laser;
    public GameObject Hero;

    void Start()
    {
         //Debug.Log("Passing Through");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
     	if(other.gameObject.tag == "ground"){
     		    Laser.SetActive(false);
                Hero.GetComponent<Rigidbody>().isKinematic = false;
           }
     }

      private void OnTriggerExit(Collider other){
     	if(other.gameObject.tag == "ground"){
     		    Laser.SetActive(true);
               
           }
     }




}
