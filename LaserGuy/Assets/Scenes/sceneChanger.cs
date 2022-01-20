using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Bricks");
        YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);

    }
    public void Leveltwo(){
    	SceneManager.LoadScene("Bricks2");
        YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
    }
    public void Levelthree(){
    	SceneManager.LoadScene("Levelone");
        YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
    }

    public void Levelfour(){
    	SceneManager.LoadScene("RigidBody");
        YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
    }
     public void LevelFive(){
        SceneManager.LoadScene("Bricks3");
        YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
    }


}
