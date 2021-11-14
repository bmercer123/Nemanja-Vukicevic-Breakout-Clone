using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed; //leaving as public for easier control through inspector
    public float rSE;
    public float lSE;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        //Paddle Movement
        //Matching the float with the Input Manager
        float horizontal = Input.GetAxis("Horizontal");

        //defining the movement od the paddle by horizontal input
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        //controlling paddle does not go off screen
        if(transform.position.x < lSE) //checking left screen edge
        {
            transform.position = new Vector2(lSE, transform.position.y);
        }
        if (transform.position.x > rSE) //checking right screen edge
        {
            transform.position = new Vector2(rSE, transform.position.y);
        }
    }
}
