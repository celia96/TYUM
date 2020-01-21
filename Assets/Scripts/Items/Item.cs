using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";

    public Sprite icon;
    public GameObject itemObject;
    public int number;
    public bool isDefaultItem = false;
    public bool isCollected = false;
    public bool isUsed = false;

    public virtual void Use(Item item)
    {
        Debug.Log("using an item " + name);
        Equipment equipment = itemObject.GetComponent<Equipment>();
        equipment.Equip(item);
    }

}
