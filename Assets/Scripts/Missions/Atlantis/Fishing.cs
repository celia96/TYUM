using UnityEngine;
using System.Collections;

public class Fishing : DropZone
{

    public static bool missionComplete = false;
    public Transform cheeseSpawn;
    public Transform fishingpoleSpawn;

    public Item cheese;
    public Item fishingpole;
    

    //private void Update()
    //{
    //    if (cheese.isUsed && fishingpole.isUsed)
    //    {
    //        StartFishing();
    //    }
    //}

    public void StartFishing()
    {
        Debug.Log("mision is complete. Start the animation mov");
    }

    public override void OnDrop(Item item)
    {
        Debug.Log("Dropping an item " + item.name);
        if (item.name == "cheese")
        {
            if (fishingpole.isUsed)
            {
                Instantiate(item.itemPrefab, cheeseSpawn.position, Quaternion.identity);
                item.Use(item);
            }
        }
        if (item.name == "fishingpole")
		{
			Instantiate(item.itemPrefab, fishingpoleSpawn.position, Quaternion.identity);
            item.Use(item);
        }
    }
}
