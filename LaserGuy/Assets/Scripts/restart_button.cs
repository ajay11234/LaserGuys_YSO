using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_button : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene("Bricks");
    }
}
