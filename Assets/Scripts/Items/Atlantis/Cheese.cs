using UnityEngine;
using System.Collections;

public class Cheese : Equipment
{

    public Item fishingpole;

    public override void Equip(Item item)
    {

        if (fishingpole.isUsed)
        {
            Debug.Log("using an item cheese === " + item.name);
            UIManager.UseItem(item);
        }
        item.isUsed = true;
    }
}

