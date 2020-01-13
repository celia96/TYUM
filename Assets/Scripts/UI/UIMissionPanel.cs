using UnityEngine;
using System.Collections;

public class UIMissionPanel : MonoBehaviour
{
    /// <summary>
    /// Open the Panel and pause the game.
    /// </summary>
    public void Open()
    {
        gameObject.SetActive(true);
    }

    /// <summary>
    /// Close the Panel and unpause the game.
    /// </summary>
    public void Close()
    {
        // click outside the panel
        gameObject.SetActive(false);

    }
}
