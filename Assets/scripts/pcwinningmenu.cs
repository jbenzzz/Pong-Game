using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pcwinningmenu : MonoBehaviour
{
    public ball Scoreübersicht;
    public int winningscore = 2;
    public Text winnertext;
    public GameObject winningUI;
    //public bool restart = false;

    private void Start()
    {
        winningUI.SetActive(false);
        
    }

    private void Update()
    {
        if (Scoreübersicht.Spieler1points == winningscore)
        {
            winnertext.text = "Spieler 1 hat gewonnen";
            gameended();
        }
        else if (Scoreübersicht.Spieler2points == winningscore)
        {
            winnertext.text = "Die KI war zu übermächtig";
            gameended();
        }


    }

    public void gameended ()
    {
        winningUI.SetActive(true);
    }

   public void playagain()
    {
        Debug.Log("playagain");
        winningUI.SetActive(false);
        SceneManager.LoadScene(1);
        
    }
}
