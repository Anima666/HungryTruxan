using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

    public float speed = 5f;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 20, 0)*Time.deltaTime*speed);
	}
}
