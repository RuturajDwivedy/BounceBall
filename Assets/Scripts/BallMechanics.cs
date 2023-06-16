using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMechanics : MonoBehaviour
{
    Rigidbody2D rb;
    public float BounceForce;
    public float z;
    bool gameStarted;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                Bounce();
                gameStarted = true;
            }
        }
    }

    void Bounce()
    {
        z = Random.Range(-1, 1);
        if(z==0)
        {
            z = 1;
        }
        Vector2 randomDirection = new Vector2(z, 1);

        rb.AddForce(randomDirection * BounceForce, ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="FallCheck")
        {
            GameManager.instance.Restart();
            Debug.Log("Collision Detected!");
        }

        else if(collision.gameObject.tag=="Paddle")
        {
            GameManager.instance.ScoreUp();
        }
    }


}
