using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";

    public Sprite icon;
    public GameObject itemPrefab;
    public int number;
    public bool isCollected = false;
    public bool isUsed = false;

    public virtual void Use(Item item)
    {
        if (item != null)
		{
			Debug.Log("using an item " + name);
			UIManager.UseItem(item);
			item.isUsed = true;
		}
    }

}
