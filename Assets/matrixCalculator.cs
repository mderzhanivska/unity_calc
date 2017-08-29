using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class matrixCalculator : MonoBehaviour {

    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField input4;
    public Text result;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Determinant()
    {
        int det;
        det = (int.Parse(input1.text) * int.Parse(input4.text)) + (int.Parse(input2.text) * int.Parse(input3.text));
        result.text = det.ToString();
    }
    
}
