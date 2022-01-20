using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

	public string scene;
   		 
     public void Restart2(){
   		SceneManager.LoadScene(scene);
   		YsoCorp.GameUtils.YCManager.instance.OnGameFinished(false);
     }


}
