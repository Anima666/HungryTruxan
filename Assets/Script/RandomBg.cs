using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomBg : MonoBehaviour {

	public Sprite[] sped;
	// Use this for initialization
	void Start () {
		GetComponent<Image> ().sprite = sped [Random.Range (0, sped.Length)];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
