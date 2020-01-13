using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Debug.Log("Touch detected!");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);
            if (hit.collider && hit.collider.CompareTag("Touchable"))
            {
                Debug.Log("Hit it! " + hit.collider.gameObject.name);
                Touchable touched = hit.collider.GetComponent<Touchable>();
                touched.OnTouch();
            }
        }
    }
}