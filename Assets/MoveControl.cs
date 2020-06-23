using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public Joystick joystick;
    public float joystickTurn = .2f;
    public float speed = 5f;
    public float yMin, yMax, xMin, xMax;
    public float freezaZ = -1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, freezaZ);
        }
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, freezaZ);
        }
        if (transform.position.y < yMin)
        {
            transform.position = new Vector3(transform.position.x, yMin, freezaZ);
        }
        if (transform.position.y > yMax)
        {
            transform.position = new Vector3(transform.position.x, yMax, freezaZ);
        }

        //float horizontalMove = joystick.Horizontal * speed;
        //float verticalMove = joystick.Vertical * speed;

        if (joystick.Horizontal >= joystickTurn)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        } else if (joystick.Horizontal <= -joystickTurn)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if(joystick.Vertical >= joystickTurn)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (joystick.Vertical <= joystickTurn)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            return;
        }
    }
}
