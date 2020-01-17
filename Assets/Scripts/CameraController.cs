using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    public Transform LeftWall;
    public Transform RightWall;
    public Transform BottomWall;
    public Transform TopWall;

    public bool xAxixEnabled;
    public bool yAxixEnabled;

    private bool canMove;
    private float xMin;
    private float xMax;
    private float yMin;
    private float yMax;
    
    void Start()
    {
        if (xAxixEnabled)
        {
            xMin = LeftWall.position.x;
            xMax = RightWall.position.x;
            //Debug.Log("x min and x max " + xMin + ", " + xMax);
        }
        if (yAxixEnabled)
        {
            yMin = BottomWall.position.y;
            yMax = TopWall.position.y;
            //Debug.Log("y min and y max " + yMin + ", " + yMax);
        }    
    }

    void LateUpdate()
    {
        // if the player can move both horizontally and vertically
        if (xAxixEnabled && yAxixEnabled)
        {
            // Camera doesn't move until the player comes to the cam center
            float xDist = Mathf.Abs(transform.position.x - player.transform.position.x);
            float yDist = Mathf.Abs(transform.position.y - player.transform.position.y);
            if (xDist <= 0.05f || yDist <= 0.05f)
            {
                canMove = true; 
            }

            if (canMove)
            {

                if ((player.transform.position.x <= xMin || player.transform.position.x >= xMax) &&
                    (player.transform.position.y > yMin && player.transform.position.y < yMax))
                {
                    // Camera should follow the player vertically only
                    //Debug.Log("Cam vertical move");
                    Vector3 temp = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
                    transform.position = temp;
                }
                if ((player.transform.position.y < yMin || player.transform.position.y > yMax) &&
                    (player.transform.position.x > xMin && player.transform.position.x < xMax))
                {
                    // Camera should follow the player horizontally only
                    //Debug.Log("Cam horizontal move");
                    Vector3 temp = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
                    transform.position = temp;
                }

                if (player.transform.position.x > xMin && player.transform.position.x < xMax &&
                player.transform.position.y > yMin && player.transform.position.y < yMax)
                {
                    // Camera should follow the player
                    //Debug.Log("Cam any move");
                    Vector3 temp = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
                    transform.position = temp;
                }
            }
            
        }
        else if (xAxixEnabled)
        {
            // if the player can only move horizontally
            float xDist = Mathf.Abs(transform.position.x - player.transform.position.x);
            if (xDist <= 0.05f)
            {
                canMove = true;
            }

            if (canMove && (player.transform.position.x > xMin && player.transform.position.x < xMax))
            {
                Vector3 temp = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
                transform.position = temp;
            }

        }
        else if (yAxixEnabled)
        {
            // if the player can only move vertically
            float yDist = Mathf.Abs(transform.position.y - player.transform.position.y);
            if (yDist <= 0.05f)
            {
                canMove = true;
            }
            if (canMove && (player.transform.position.y > yMin && player.transform.position.y < yMax))
            {
                Vector3 temp = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
                transform.position = temp;
            }
        }
    }

}
