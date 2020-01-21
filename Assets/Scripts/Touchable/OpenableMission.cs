using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableMission : Touchable
{

    [Tooltip("Mission Panel to be opened. Gets enabled and disabled.")]
    public UIMissionPanel missionPanel;

    [Tooltip("Touch Controls get enabled and disabled.")]
    public TouchControls touchControls;

    public override void OnTouch()
    {
        Debug.Log("opening a mission");

        touchControls.ToggleTouch();

        UIManager.instance.inventoryPanel.Close();
        missionPanel.Open();
    }

}
