using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this;
    }

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallback;

    public static List<Item> items = new List<Item>();


    public void Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            Debug.Log("adding an item to the inventory");
            items.Add(item);

            if (OnItemChangedCallback != null)
            {
                OnItemChangedCallback.Invoke();
            }
        }
    }

    public void Remove(Item item)
    {
        Debug.Log("removing an item from an inventory");
        items.Remove(item);

        if (OnItemChangedCallback != null)
        {
            OnItemChangedCallback.Invoke();
        }
    }

}
