using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plankton : MonoBehaviour
{

    public Item item;
    public float planktonSpeedRate;


    // Update is called once per frame
    void Update()
    {
        float X = 1 + Mathf.Sin (Time.time * planktonSpeedRate) * 0.1f; 	// range from 0.8 to 1.2
		float Y = 1 + Mathf.Cos (Time.time * planktonSpeedRate) * 0.1f;	// Time.time * (speed rate) (from 3 to 10)
		transform.localScale = new Vector3 (X, Y, 1);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            item.isCollected = true;
            item.number += 1;
            UIManager.ObtainItem(item);
            PlanktonSpawn.instance.OnCollectPlankton();
            Destroy(gameObject);
        }
    }
}
