using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Level : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Endscrn;
    public GameObject DoorLeft;
   public GameObject DoorRight;
   public float pos;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
                Endscrn.gameObject.SetActive(true);
                 DoorLeft.transform.position = new Vector3(DoorLeft.transform.position.x + (pos - 2.4f), DoorLeft.transform.position.y, DoorLeft.transform.position.z);
               DoorRight.transform.position = new Vector3(DoorRight.transform.position.x - pos, DoorRight.transform.position.y, DoorRight.transform.position.z);
        }

    }

    
}
