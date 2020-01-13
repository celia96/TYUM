using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Touchable
{

    public string sceneToLoad;
    private SpriteRenderer spriteRenderer;
    private bool opened;

    void Start()
    {
        opened = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void OnTouch()
    {
        Debug.Log("touched");
        //if (!opened)
        //{
        //    OpenDoor();
        //}
        //else
        //{
        //    ChangeScene();
        //}

        ChangeScene();

    }

    public void OpenDoor()
    {
        // open the door (change the sprite)
        //spriteRenderer.sprite = sprites[1];
        spriteRenderer.color = new Color(0, 0, 0);
        opened = !opened;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
