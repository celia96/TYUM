using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fridge : Touchable
{
    public Sprite fridgeOpened;
    public GameObject cheesePrefab;
    public Transform cheeseSpawn;
    private SpriteRenderer spriteRenderer;
    private static bool opened = false;

    // Start is called before the first frame update
    void Start()
    {
		spriteRenderer = GetComponent<SpriteRenderer>();
		if (opened)
		{
			spriteRenderer.sprite = fridgeOpened;
		}
        
    }


    public override void OnTouch()
    {
        if (!opened)
        {
            Debug.Log("open fridge");
            opened = true;
            spriteRenderer.sprite = fridgeOpened;

            // spawn cheese game object
            Instantiate(cheesePrefab, cheeseSpawn.position, Quaternion.identity);
            
        }
        
    }
}
