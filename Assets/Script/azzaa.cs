using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class azzaa : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        SceneManager.LoadScene("main");
	}
}
