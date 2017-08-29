using UnityEngine;
using System.Collections;


public class loadscenes : MonoBehaviour {

	// Use this for initialization
	public void m2x2 () {
        Application.LoadLevel(1);

	}
    public void calc ()
    {
        Application.LoadLevel(0);

    }
   

    
    public void m3x3()
    {
        Application.LoadLevel(2);

    }

    public void m4x4()
    {
        Application.LoadLevel(3);

    }
	
}
