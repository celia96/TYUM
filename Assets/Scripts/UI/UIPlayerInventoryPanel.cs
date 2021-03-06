﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInventoryPanel : MonoBehaviour
{
	public int numberOfSlots = 4;
    public InventorySlot[] slots;

    private Inventory inventory;


    void Start()
    {
        inventory = Inventory.instance;

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
