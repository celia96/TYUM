using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public float speed;
    public FixedJoystick joystick;
    public Rigidbody2D rb;
    public bool yEnabled = false;

    public void FixedUpdate()
    {
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);
        Vector2 vel = rb.velocity;
        vel.x = input.x * speed;
        if (yEnabled) {
            vel.y = input.y * speed;
        }
        //vel.y += Time.deltaTime;
        rb.velocity = vel;
        //UpdateAnimations();

        //Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}