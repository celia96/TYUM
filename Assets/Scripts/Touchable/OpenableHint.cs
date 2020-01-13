using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableHint : Touchable
{

	[Tooltip("Hint Sprite to render.")]
	public Sprite hintImage;

    public override void OnTouch()
    {
        UIManager.OpenHint(hintImage);
    }

}
