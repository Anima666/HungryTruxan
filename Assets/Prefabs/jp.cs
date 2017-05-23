using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class jp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	public Vector2 jumpforce = new Vector2(0, 300);
	public AudioClip st;
	public GameObject rb;


	// Update is called once per frame
	void OnMouseDown () {
		//AudioSource audio1 = GetComponent<AudioSource>();
	   // audio1.clip = st;
	//    audio1.Play();
		rb.GetComponent<Rigidbody2D>().velocity = (Vector2.zero);
        rb.GetComponent<Rigidbody2D>().AddForce(jumpforce);
	}   
}
