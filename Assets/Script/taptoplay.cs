using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class taptoplay : MonoBehaviour {

    private Text text;
    public Text score;
    public GameObject obstacle;
    public GameObject generate;
    public  GameObject player;
    public GameObject audio;
    void Start ()
    {

      //  Cursor.visible = false;
        text = GetComponent<Text>();
        player.GetComponent<Animator>().enabled = true;
        score.GetComponent<Text>().enabled = false;
        // obstacle.GetComponent<Obstacle>().enabled = false;
        obstacle.SetActive(false);
        generate.GetComponent<Generate>().enabled = false;

    }

    bool ch = false;
	void Update ()
    {
        if (text.lineSpacing >= 1.33f)
            ch = true;
        if (text.lineSpacing <= 0.7f)
            ch = false;
        if (ch == false)
            text.lineSpacing += 0.04f;
        else
            text.lineSpacing -= 0.04f;

    }
    void OnMouseDown()
    {
        audio.GetComponent<AudioSource>().volume = 0.1f;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.SetActive(false);
        // obstacle.GetComponent<Obstacle>().enabled = true;
        obstacle.SetActive(true);
        player.GetComponent<Rigidbody2D>().isKinematic = false;
        player.GetComponent<Animator>().enabled = false;
        score.GetComponent<Text>().enabled = true;
        generate.GetComponent<Generate>().enabled = true;
        //player.transform.Rotate(new Vector3(0,0,0));
        player.transform.rotation = Quaternion.Euler(0, 0, 0);


    }
    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;
    //void OnMouseEnter()
    //{
    //    Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    //}

    //void OnMouseExit()
    //{
    //    Cursor.SetCursor(null, Vector2.zero, cursorMode);
    //}
}

