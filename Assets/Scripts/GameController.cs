using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    private int score;
    public GUIText scoreText;

    void Update()
    {
        bool pressed = Input.GetButtonDown("Fire2");
        if (pressed)
        {
            nextlevel();
        }
    }

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

    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
	
}
