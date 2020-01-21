using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Touchable
{

    public Item item;

    void Start()
    {
        if (item.isCollected)
        {
            Destroy(gameObject);
        }    
    }


    public override void OnTouch()
    {
        OnCollect();
    }

    public void OnCollect() {
        Debug.Log("collecting " + item.name);
        item.isCollected = true;
        item.number += 1;
        UIManager.ObtainItem(item);
        Destroy(gameObject);
    }

}
