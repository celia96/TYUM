using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableMission : Touchable
{

    [Tooltip("Mission Panel to be opened. Gets enabled and disabled.")]
    public UIMissionPanel missionPanel;

    public override void OnTouch()
    {
        Debug.Log("opening mission");
        UIManager.instance.missionPanel = missionPanel;
        UIManager.OpenMission();
    }

}
