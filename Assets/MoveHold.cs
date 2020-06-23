using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHold : MonoBehaviour
{

    private Vector3 mousePosition;
    private Rigidbody rb;
    private Vector3 direction;
    public float speed = 5f;
   

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }



}