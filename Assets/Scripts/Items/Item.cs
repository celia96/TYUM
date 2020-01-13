using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";

    public Sprite icon;
    public bool isDefaultItem = false;


    public virtual void Use(Item item)
    {
        Debug.Log("using an item " + name);
        UIManager.UseItem(item);
    }
}
