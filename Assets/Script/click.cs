using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class click : MonoBehaviour {
    int i = 0;

    public Text t;
 

    void OnMouseDown()
    { 
        i++;
        System.Console.WriteLine(i);

        t.text = System.Convert.ToString(i);
    }
	

}
