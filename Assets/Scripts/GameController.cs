using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    private int score;
    public GUIText scoreText;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        GetComponent<AudioSource>().Play();
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
	
}
