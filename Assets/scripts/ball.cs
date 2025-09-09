using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ball : MonoBehaviour {

    public float speed = 8f;
    public int Spieler1points=0;
    public int Spieler2points=0;
    public Text textSpieler1;
    public Text textSpieler2;
   

	
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0)*speed;
	}
	
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Spieler1")
        {
            float hitposition = ballhit(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 newDirection = new Vector2(1, hitposition);
            GetComponent<Rigidbody2D>().velocity = newDirection * speed;

            speed += 1;
        }

        if (collision.gameObject.name == "Spieler2")
        {
            float hitposition = ballhit(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 newDirection = new Vector2(-1,hitposition);
            GetComponent<Rigidbody2D>().velocity = newDirection * speed;

            speed += 1;
        }

        if (collision.gameObject.name == "wallleft")
        {
            Spieler2points++;
            textSpieler2.text = Spieler2points.ToString();
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            resetBallposition();
            Invoke("resetBallspeed",1);

        }

        if (collision.gameObject.name == "wallright")
        {
            Spieler1points++;
            textSpieler1.text = Spieler1points.ToString();
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
            resetBallposition();
            Invoke("resetBallspeed",1);
        }


    }

   public void resetBallspeed ()
    {
        speed = 8f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;   
    }

    public void resetBallposition()
    {
        GetComponent<Rigidbody2D>().position = new Vector2(1, 0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }



    public void resetScore()
    {
    Spieler1points = 0;
    Spieler2points = 0;
    }

    float ballhit (Vector2 positionBall, Vector2 positionBat, float hightbat)
    {
        float position = (positionBall.y - positionBat.y) / hightbat;
        return position;
    }

    public void manualstart ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
    }
}
