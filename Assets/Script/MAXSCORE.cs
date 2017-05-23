using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MAXSCORE : MonoBehaviour {

	// Use this for initialization
	public Text t;
	public Text t2;
	void Start () {
		t.text ="BEST: "+PlayerPrefs.GetInt ("BestScore").ToString();
		t2.text="SCORE: "+PlayerPrefs.GetInt("Score1").ToString();
	}
	
	// Update is called once per frame

}
