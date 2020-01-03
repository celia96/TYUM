using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRend;
    private int spriteVersion = 0;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(WaterAnimationCoroutine(speed));
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void UpdateAnimations()
    {
        Debug.Log("updating animation");
    }

    IEnumerator WaterAnimationCoroutine(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            if (spriteVersion == sprites.Length - 1)
            {
                spriteVersion = 0;
            } else
            {
                spriteVersion += 1;
            }
            spriteRend.sprite = sprites[spriteVersion];
        }

    }
}
