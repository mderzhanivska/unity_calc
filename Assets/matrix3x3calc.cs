using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class matrix3x3calc : MonoBehaviour
{

    public InputField inp11;
    public InputField inp12;
    public InputField inp13;
    public InputField inp21;
    public InputField inp22;
    public InputField inp23;
    public InputField inp31;
    public InputField inp32;
    public InputField inp33;
    public Text result3x3;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Determinant()
    {
        int det;
        det = (int.Parse(inp11.text) * int.Parse(inp22.text) * int.Parse(inp33.text)) - (int.Parse(inp11.text) * int.Parse(inp23.text) * int.Parse(inp32.text)) - (int.Parse(inp12.text) * int.Parse(inp21.text) * int.Parse(inp33.text)) + (int.Parse(inp12.text) * int.Parse(inp23.text) * int.Parse(inp31.text)) + (int.Parse(inp13.text) * int.Parse(inp21.text) * int.Parse(inp32.text)) - (int.Parse(inp13.text) * int.Parse(inp22.text) * int.Parse(inp31.text)) ;
        result3x3.text = det.ToString();
    }

}
