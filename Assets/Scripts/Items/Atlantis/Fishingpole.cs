using UnityEngine;
using System.Collections;

public class Fishingpole : Equipment
{

    public override void Equip(Item item)
    {
        Debug.Log("using an item cheese === " + item.name);
        UIManager.UseItem(item);
        item.isUsed = true;
    }
}
