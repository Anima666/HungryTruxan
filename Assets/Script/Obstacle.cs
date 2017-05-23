using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    // Use this for initialization
    public Vector2 velocity = new Vector2(-150, 0);
   // public float range = 2;
	void Start () {
        GetComponent<Rigidbody2D>().velocity = velocity;
       // Destroy(gameObject,30);
    }

	
	
}
