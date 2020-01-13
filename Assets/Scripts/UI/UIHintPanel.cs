using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHintPanel : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // touch outside the panel
        // close the panel
    }
    /// <summary>
    /// Open the Panel and pause the game.
    /// </summary>
    public void Open(Sprite hintImage)
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<Image>().sprite = hintImage;
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
