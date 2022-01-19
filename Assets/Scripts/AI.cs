using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float Speed = 10;

    public GameObject ball;

    private Vector2 ballPos;


    void Update()
    {
        Move();
    }

    void Move()
    {
        ballPos = ball.transform.position;
        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -Speed * Time.deltaTime);
        }
        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, Speed * Time.deltaTime);

        }
    }

    
}
