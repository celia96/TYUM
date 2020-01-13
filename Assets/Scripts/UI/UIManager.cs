using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [Tooltip("Instance of the inventory panel script to manage.")]
    public UIPlayerInventoryPanel inventoryPanel;
    [Tooltip("Instance of the hint panel script to manage.")]
    public UIHintPanel hintPanel;
    [Tooltip("Instance of the mission panel script to manage.")]
    public UIMissionPanel missionPanel;

    private Image image;

    public static UIManager instance;

    void Start()
    {
        instance = this;
        image = GetComponent<Image>();
    }

    public static void ObtainItem(Item item)
    {
        Inventory.instance.Add(item);
    }

    public static void UseItem(Item item)
    {
        Inventory.instance.Remove(item);
        // Player.instance => update the player sprite as well
    }

    public static void OpenHint(Sprite hintImage)
    {
        Debug.Log("open hint");
        instance.image.enabled = true;
        instance.inventoryPanel.Close();
        instance.hintPanel.Open(hintImage);
    }


    public static void OpenMission()
    {
        Debug.Log("open mission");
        instance.image.enabled = true;
        instance.inventoryPanel.Close();
        instance.missionPanel.Open();
    }

}
