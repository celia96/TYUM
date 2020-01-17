using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHintPanel : MonoBehaviour
{

    public void Open()
    {
        gameObject.SetActive(true);
    }


    public void Close()
    {
        // click outside the panel
        gameObject.SetActive(false);

    }
}
