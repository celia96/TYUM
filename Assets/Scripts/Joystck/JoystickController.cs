using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{

    public float speed;
    public Joystick joystick;
    public bool yEnabled;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = true;
        anim = GetComponent<Animator>();
    }


    public void FixedUpdate()
    {
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);
        Vector2 vel = rb.velocity;
        vel.x = input.x * speed;

        if (vel.x > 0)
        {
            vel = new Vector2(speed, vel.y);
            spriteRenderer.flipX = true;
        }
        if (vel.x < 0)
        {
            vel = new Vector2(-speed, vel.y);
            spriteRenderer.flipX = false;
        }
        else
        { // Reduce sliding movement
            rb.velocity = new Vector2(0, vel.y);
        }


        if (yEnabled) {
            vel.y = input.y * speed;
        }
        //vel.y += Time.deltaTime;
        rb.velocity = vel;


        UpdateAnimations();
        
        //Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    void UpdateAnimations()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }

}