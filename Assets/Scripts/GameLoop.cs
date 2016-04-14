using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameLoop : MonoBehaviour {

	private int pops = 0;
	public string Level;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void incrementPops ()
	{
		pops++;
		if (pops == 3) {
			SceneManager.LoadScene (Level);

		}
	}
}
