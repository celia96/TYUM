using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Touchable
{

    public Item item;

    public override void OnTouch()
    {
        OnCollect();
    }

    public void OnCollect() {
        Debug.Log("collecting " + item.name);
        UIManager.ObtainItem(item);
        Destroy(gameObject);
    }

}
