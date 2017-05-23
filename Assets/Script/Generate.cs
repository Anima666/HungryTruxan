using UnityEngine;
using System.Collections;
using System.Threading;

public class Generate : MonoBehaviour {
    public GameObject rock;
	public GameObject egg;

    int score;
	float[] mass =new float[4];
    public float range=100;

    // Use this for initialization
    GameObject rock2;
    void Start () {
		
		mass[0]  = 135;
		mass [1] = 191;
		mass [2] = 245;
        //mass [3] = 115;
        rock2 = rock;
        InvokeRepeating("CreateOb", 0f, 2.65f); //2.65
	}

   
   
	void CreateOb()
	{
        
		//rock.transform.position= new Vector2(rock.transform.position.x,191f);
		rock2.transform.position = new Vector3 (1144, mass [Random.Range (0, 3)], -10);
        Instantiate(rock2);

        //score++;
    }
}
	
