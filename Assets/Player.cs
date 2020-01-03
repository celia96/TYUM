using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateAnimations()
    {
        Debug.Log("updating animation");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if the other object has the zombie tag, eat the brain and continue the game
        Debug.Log("collided");
        Debug.Log(other.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if (other.CompareTag("Item"))
        {
            Debug.Log("Hello");
            Destroy(other.gameObject);
        }

    }

}
