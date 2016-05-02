using UnityEngine;
using System.Collections;

public class PauseCode : MonoBehaviour {

    public string mainMenu;
    public bool isPaused;
    public GameObject pauseMenuCanvas;
	
	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

	}
    public void Resume()
    {
        isPaused = false;
    }
    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }

}
