using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    // if the other object has the zombie tag, eat the brain and continue the game
    //    Debug.Log("collided");
    //    Debug.Log(other.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Hello");
    //        Destroy(gameObject);
    //    }

    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }

    //void OnCollisionStay2D(Collision2D col)
    //{
    //    if (col.collider.CompareTag("Player"))
    //    {
    //        Player player = col.transform.root.GetComponentInChildren<Player>();
    //        player.Hurt();
    //    }
    //}
}
