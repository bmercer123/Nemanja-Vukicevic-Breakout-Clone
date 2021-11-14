using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;
    public GameManager gm; // referencing to the manager

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Random.Range(-3f,3f),1);
        if (gm.gameOver)
        {
            return;
        }
        if (!inPlay)
        {
            transform.position = paddle.position;
        }  
        if(Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(direction * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bottom")) // if the collision is with the bottom collider
        {
            rb.velocity = Vector2.zero;
            inPlay = false;
            gm.UpdateLives(-1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("brick"))  // if the collision is with the brick collider
        {
            gm.UpdateScore(collision.gameObject.GetComponent<Brick>().points); // getting points value from Brick script

            Destroy(collision.gameObject);
        }
    }
}
