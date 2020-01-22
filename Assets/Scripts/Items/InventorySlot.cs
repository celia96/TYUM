using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

	public Image icon;
    public Text numberText;
    [HideInInspector] public Item item;


    public void AddItem(Item newItem)
	{
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        if (item.number > 1)
        {
            numberText.text = "x" + item.number.ToString();
        } 
	}

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        numberText.text = "";
    }


    //public void UseItem()
    //{
    //    if (item != null)
    //    {
    //        item.Use(item);
    //    } else
    //    {
    //        Debug.Log("Cannot use this item");
    //    }
    //}

}
