using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class calculation : MonoBehaviour {
    //оголошення змінних
    Text resultText;
    double result=0.0;
    double tempSave;
    string operation;
    double multiplier = 1;
    double memory;
    int resultNumber;

	// Use this for initialization
	void Start () 
    {
        resultText = GameObject.Find("Result").GetComponent<Text>();

	}
	
	// Update is called once per frame
    void Update()
    { }
	
	

    public void WriteToTextField() //створить вікно де будуть показуватися вікна
    {
        resultText.text = "" + result; 
    }

    public void ClearResult() //очищатиме до 0
    {
        result = 0.0;
        WriteToTextField();
        multiplier = 1;
    }

    public void saveOperation(string o)
    {
        multiplier = 1;
        operation = o;
        tempSave = result;
        result = 0.0;
        resultText.text = operation;
    }

    public void AddDigit(int d) //функія активується коли multiplier==1 
    {
        if (multiplier == 1)
        {
            result *= 10;
            result += d;
            WriteToTextField();
        }
        else
        {
            result += d * multiplier;
            multiplier /= 10;
        }
    }

    public void setMultiplier()
    {
        multiplier = 0.1;
    }

    public void saveMemory()
    {
        memory = result;
        multiplier = 1;
    }

    public void readMemory()
    {
        result = memory;
        WriteToTextField();
        multiplier = 1;
    }
    public void AddDigitPI()
    {
        double d = System.Math.PI;
        if (multiplier == 1)
        {
            result *= 10;
            result += d;
        }
        else 
        {
            result += d * multiplier;
            multiplier /= 10;
        }
        WriteToTextField();
    }

    public void calcResult()
    {
        switch (operation)
        { 
            case "+":
                result = tempSave + result;
                break;
            case "-":
                result = tempSave - result;
                break;
            case "/":
                result = tempSave / result;
                break;
            case "*":
                result = tempSave * result;
                break;
            case "%":
                result = tempSave % result;
                break;
            case "sqrt":
                result = System.Math.Sqrt(tempSave);
                break;
           
        }
        operation = "";
        multiplier = 1;
        WriteToTextField();
    }

}
