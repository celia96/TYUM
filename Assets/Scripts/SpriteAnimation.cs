using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [Tooltip("The individual sprites of the animation")]
    public Sprite[] frames;
    [Tooltip("How fast does the animation play")]
    public float framesPerSecond;

    private SpriteRenderer spriteRenderer;
    private int spriteVersion = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (frames.Length >= 1)
        {
            StartCoroutine(PlayAnimation(framesPerSecond));
        }
    }

    IEnumerator PlayAnimation(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);

            if (spriteVersion == frames.Length - 1)
            {
                spriteVersion = 0;
            } else
            {
                spriteVersion += 1;
            }
            spriteRenderer.sprite = frames[spriteVersion];
        }

    }
}
