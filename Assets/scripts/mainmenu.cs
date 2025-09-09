using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void PlayvsPC()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }


    public void Quit()
    {
        Debug.Log("Spiel beendet");
        Application.Quit();
    }

    public void tomenu ()
    {
        SceneManager.LoadScene(0);
       // Time.timeScale = 1f;
    }


}
