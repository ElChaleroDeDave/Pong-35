using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;


    public float speed = 5;
    public Rigidbody2D rb;

    private float move;
    private Vector2 startPos;


    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical");
        }
         else
        {
            move = Input.GetAxisRaw("Vertical2");

        }

        rb.velocity = new Vector2(rb.velocity.x, move * speed); 
        

  
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
