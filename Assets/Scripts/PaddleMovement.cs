using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
     Rigidbody2D rb;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        TouchMovement();
    }

    void TouchMovement()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(pos.x<0)
            {
                //move left
                rb.velocity = Vector2.left * speed;
            }
            else if(pos.x>0)
            {
                //move right
                rb.velocity = Vector2.right * speed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;     
        }
    }
}
