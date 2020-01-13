using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone : MonoBehaviour
{

    public string numberToCall;
    public string pressedNumbers;

    public void Call()
    {
        if (numberToCall == pressedNumbers)
        {
            Debug.Log("Correct Number!");
        } else
        {
            Debug.Log("Wrong Number!");
        }
    }

    public void Clear()
    {
        pressedNumbers = "";
    }

    public void PressNumber(int number)
    {
        pressedNumbers += number.ToString();
        Debug.Log("Now... " + pressedNumbers);
    }

}
