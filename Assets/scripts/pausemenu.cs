using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public bool gameispaused = false;
    public GameObject pauseUI;

    public void Start()
    {
       // pauseUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused==false)
            {
                pause();
            }
            else if (gameispaused==true)
            {
                resume();
            }
        }
    }
    public void pause ()
    {
        pauseUI.SetActive(true);
        gameispaused = true;
        Debug.Log("Pause");
       Time.timeScale = 0f;
    }

    public void resume ()
    {
        Debug.Log("REsume");
        pauseUI.SetActive(false);
        gameispaused = false;
        Time.timeScale = 1f;
    }

}


