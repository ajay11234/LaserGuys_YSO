using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

// [RequireComponent (typeof (LineRenderer))]
[RequireComponent(typeof(LineRenderer))]
public class LineRendcollide : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer lr;

    public Joystick joystick;
    public float rotateVertical;
    public float rotateHorizontal;

    public ParticleSystem particleSys;
    public ParticleSystem Guntip;
    public ParticleSystem GunEnd;
    public GameObject Player;
    public float dist;
     public Rigidbody rb;

    public float MainTextureLength = 1f;
    public float NoiseTextureLength = 1f;
    private Vector4 Length = new Vector4(1,1,1,1);

    public float MaxLength;

    float Jetup = 0f;

     //public GameObject BladeCut;

    public GameObject arrowPad;
     

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody>();
        Player.GetComponent<Rigidbody>().isKinematic = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //lr.SetPosition(0, transform.position);
        if(joystick.Vertical == 0){  
             GunEnd.Stop();
            lr.enabled = false;
             particleSys.Stop();
             Guntip.Stop();
             Jetup = 0f;
             Player.GetComponent<Rigidbody>().isKinematic = false;
            }else if(joystick.Vertical > 0 || joystick.Vertical < 0){
                //Jetup += 0.2f;
                Destroy(arrowPad);
                Invoke("LaunchProjectile", 1.0f);
                lr.enabled = true;
                Laser();
                Player.GetComponent<Rigidbody>().isKinematic = true;
            }
    }
    void LaunchProjectile()
    {
       // BladeCut.active = true;
    }


    void Laser(){
         RaycastHit hit;
         lr.material.SetTextureScale("_MainTex", new Vector2(Length[0], Length[1]));                    
        lr.material.SetTextureScale("_Noise", new Vector2(Length[2], Length[3]));
         if (Physics.Raycast(transform.position, transform.forward, out hit)){
            if(hit.collider.tag == "enemy_static"){
                    Player.transform.Translate(transform.forward * -19.5f * Time.deltaTime); 
            }
             if(hit.collider.tag == "Enemy"){
                      //hit.transform.SendMessage("HitByRay");
                     //print(hit.collider.gameObject.name);  
                       Player.transform.Translate(transform.forward * -19.5f * Time.deltaTime); 
                      //Player.transform.Translate(transform.forward * -value * Time.deltaTime);                           
             }

            if(hit.collider.tag == "ground"){
                 //print(hit.collider.gameObject.name);
                // Debug.Log("Shoot Nothing", hit.distance);
                lr.SetPosition(1,new Vector3(0,0,hit.distance));
                dist = hit.distance;
                //Debug.Log(dist);

                //Debug.Log("hit point "+hit.collider.gameObject.name);

              particleSys.transform.position = hit.point;
              GunEnd.transform.position = hit.point;
              Guntip.Play();

            
                GunEnd.Play();
               
                    Player.transform.Translate(transform.forward * -19f * Time.deltaTime);
               

              
            }

        }

    }

    

   
}
    
