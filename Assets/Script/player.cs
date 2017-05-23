using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class player : MonoBehaviour
{
    public int i = 0;

    public AudioClip st, ti, oe;

    public Text score1;

    int score;
    

    void Start()
    {

    }
    public Vector2 jumpforce = new Vector2(0, 300);


    void Update()
    {

        if (Input.GetKeyUp("space")) // клик
        {
            GetComponent<Rigidbody2D>().velocity = (Vector2.zero);
            GetComponent<Rigidbody2D>().AddForce(jumpforce);
        }
  
            if (transform.position.y < -10 || transform.position.y>400)
            {

                PlayerPrefs.SetInt("Score1", score);
                if (PlayerPrefs.GetInt("BestScore") < score)
                    PlayerPrefs.SetInt("BestScore", score);
                SceneManager.LoadScene("lose");
            }

	
    }

    //Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
    //  if screenPositio.y > Screen.height
    //   public Vector2 velocity = new Vector2(-100, 0);
    public GameObject collona;
    public float speed=150f;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name != "bolno")
        {
            score++;
            score1.text = score.ToString();
        }


        speed = collona.GetComponent<Obstacle>().velocity.x - 5;
        collona.GetComponent<Obstacle>().velocity = new Vector2(speed, 0);
        

    }
    void OnCollisionEnter2D(Collision2D col)
    { 
		PlayerPrefs.SetInt("Score1",score);
		if (PlayerPrefs.GetInt("BestScore")<score)
			PlayerPrefs.SetInt("BestScore",score);
        SceneManager.LoadScene("lose");
    }
}

   
    