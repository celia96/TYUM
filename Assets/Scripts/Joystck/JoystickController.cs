using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{

    public static JoystickController instance;

    public float speed;
    public Joystick joystick;

    public bool xEnabled;
    public bool yEnabled;

    public bool flipEnabled;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = false;
        anim = GetComponent<Animator>();
    }


    public void FixedUpdate()
    {
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);
        Vector2 vel = rb.velocity;

        if (xEnabled)
        {
            vel.x = input.x * speed;

            if (vel.x > 0)
            {
                vel = new Vector2(speed, vel.y);
                spriteRenderer.flipX |= flipEnabled; // if flipEnabled, flipX = true
            }
            if (vel.x < 0)
            {
                vel = new Vector2(-speed, vel.y);
                spriteRenderer.flipX &= !flipEnabled; // if flipEnabled, flipX = false
            }
            else
            { // Reduce sliding movement
                rb.velocity = new Vector2(0, vel.y);
            }
        }

        if (yEnabled) {
            vel.y = input.y * speed;
        }

        if (xEnabled && yEnabled)
        {
            if (Mathf.Abs(input.x) > 0 && Mathf.Abs(input.y) > 0)
            {
                float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg - 90; // multiply Mathf.Rad2Deg to convert radian to degree
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
        

        rb.velocity = vel;
        UpdateAnimations();
    }

    void UpdateAnimations()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }


    public void ChangePlayer(Sprite sprite, Animator animator)
    {
        spriteRenderer.sprite = sprite;
        anim = animator;
    }

}