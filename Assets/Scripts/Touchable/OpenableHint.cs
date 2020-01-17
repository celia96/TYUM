using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableHint : Touchable
{

    [Tooltip("Hint Panel to be opened. Gets enabled and disabled.")]
    public UIHintPanel hintPanel;

    public override void OnTouch()
    {
        Debug.Log("opening a hint");

        UIManager.instance.inventoryPanel.Close();
        hintPanel.Open();
    }

}
