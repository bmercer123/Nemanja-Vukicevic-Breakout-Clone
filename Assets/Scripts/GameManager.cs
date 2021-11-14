using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives; // setting the lives text for the UI
        scoreText.text = "Score: " + score; // setting the score text for the UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        //check for remaining lives part

        livesText.text = "Lives: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;

        //check for remaining lives part

        scoreText.text = "Score: " + score;
    }
}
