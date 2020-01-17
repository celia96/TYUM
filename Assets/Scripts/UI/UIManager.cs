using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [Tooltip("Instance of the inventory panel script to manage.")]
    public UIPlayerInventoryPanel inventoryPanel;


    public static UIManager instance;

    void Start()
    {
        instance = this;
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


}
