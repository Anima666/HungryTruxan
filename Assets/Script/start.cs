using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	    public void Press () {
        SceneManager.LoadScene("main");
	}
}
