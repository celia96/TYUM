using UnityEngine;
using System.Collections;

public class Fishing : MonoBehaviour
{

    public Transform target;

    public Item cheese;
    public Item fishingpole;

    public static bool missionComplete = false;


    public void StartFishing()
    {
        if (cheese.isUsed && fishingpole.isUsed)
        {
            Debug.Log("mision is complete. Start the animation mov");
            missionComplete = true;
        }
    }

   
}
