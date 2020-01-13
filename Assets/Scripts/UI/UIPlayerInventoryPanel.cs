using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInventoryPanel : MonoBehaviour
{
	public int numberOfSlots = 4;
    public InventorySlot[] slots;

    private Inventory inventory;


    [Tooltip("How many items are currently shown active")]
    public int currentItems;

    void Start()
    {
        inventory = Inventory.instance;
        Debug.Log("logging item count " + Inventory.items.Count);
        for (int i = 0; i < numberOfSlots; i++)
        {
            if (i < Inventory.items.Count)
            {
                slots[i].AddItem(Inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        inventory.OnItemChangedCallback += UpdateUI;
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");

        for (int i = 0; i < numberOfSlots; i++)
        {
            if (i < Inventory.items.Count)
            {
                slots[i].AddItem(Inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

}
