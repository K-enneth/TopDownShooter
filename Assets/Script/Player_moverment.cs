using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_moverment : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Vector2 mousePos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(directionX, directionY).normalized;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

    }

    private void FixedUpdate()
    {
        rb.velocity= new Vector2(direction.x * speed, direction.y * speed);
        Vector2 aim = mousePos - rb.position;
        float aimAngle = Mathf.Atan2(aim.y, aim.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
