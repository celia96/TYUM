using UnityEngine;
using UnityEngine.Video;

public class Fishing : DropZone
{

    public static bool missionComplete = false;
    public Transform cheeseSpawn;
    public Transform fishingpoleSpawn;

    public Item cheese;
    public Item fishingpole;

    public VideoPlayer video;

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
        // Each time we reach the end, we slow down the playback by a factor of 10.
        video.loopPointReached += EndReached;
        video.Play();
    }

    void EndReached(VideoPlayer vp)
    {
        vp.playbackSpeed /= 10.0F;
        Debug.Log("hello Fishing ending");
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
                StartFishing();
            }
        }
        if (item.name == "fishingpole")
		{
			Instantiate(item.itemPrefab, fishingpoleSpawn.position, Quaternion.identity);
            item.Use(item);
        }
    }
 
}
