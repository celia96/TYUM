using UnityEngine;
using UnityEngine.UI;

public class Telephone : MonoBehaviour
{

    public string numberToCall;
    public string pressedNumbers;

    public Text numberText;

    public static bool missionComplete;

    void Start()
    {
        numberText.text = pressedNumbers;
    }

    public void Call()
    {
        if (numberToCall == pressedNumbers)
        {
            numberText.text = "Correct Number!";
            Debug.Log("mision is complete. Start the animation mov");
            missionComplete = true;
            // play MOV
            if (Fishing.missionComplete == true)
            {
                Debug.Log(" play complete animation mov ");
            } else
            {
                Debug.Log(" play incomplete animation mov ");
                missionComplete = false;
            }

        } else
        {
            numberText.text = "Wrong Number!";
        }
    }

    public void Clear()
    {
        pressedNumbers = "";
        numberText.text = pressedNumbers;
    }

    public void PressNumber(int number)
    {
        pressedNumbers += number.ToString();
        numberText.text = pressedNumbers;
    }

    public void PressChar(string str)
    {
        pressedNumbers += str;
        numberText.text = pressedNumbers;
    }

}
