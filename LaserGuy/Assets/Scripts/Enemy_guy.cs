using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_guy : MonoBehaviour
{
	public GameObject enemy;
    public GameObject cube; 
    public GameObject CrawlAnimator;

    int g = 0;

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cutter"){
        	//stickman.transform.localScale = new Vector3(1,1,1);
        	//Debug.Log("Blade");
        	//cube.GetComponent<Collider>().enabled = false;
        	//cube.GetComponent<MeshRenderer>().enabled = false;
            //g = g + 1;
            //Debug.Log(g);
        	Destroy(cube);
        	Vector3 pos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        	Instantiate(enemy,pos,enemy.transform.rotation);
        }

    }
}
