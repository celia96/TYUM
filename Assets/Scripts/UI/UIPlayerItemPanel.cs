using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerItemPanel : MonoBehaviour
{

    private List<GameObject> items;
    public Text itemText;

    [Tooltip("How many items are currently shown active")]
    public int currentItems;

    void Start()
    {
        currentItems = 0;
        items = new List<GameObject>();
    }

    public void AddItem(GameObject item)
    {
        Debug.Log("obtaining an item");
        items.Add(item);
        currentItems++;
        SetText();
    }

    public void RemoveItem(GameObject item)
    {
        Debug.Log("using an item");
        items.Remove(item);
        currentItems--;
        SetText();
    }

    public void SetText()
    {
        itemText.text = currentItems.ToString();

    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

}
