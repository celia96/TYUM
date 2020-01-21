using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableHint : Touchable
{

    [Tooltip("Hint Panel to be opened. Gets enabled and disabled.")]
    public UIHintPanel hintPanel;
    [Tooltip("Touch Controls get enabled and disabled.")]
    public TouchControls touchControls;

    public override void OnTouch()
    {
        Debug.Log("opening a hint");

        touchControls.ToggleTouch();

        UIManager.instance.inventoryPanel.Close();
        hintPanel.Open();
    }

}
