using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameLoop : MonoBehaviour {

	public static int pops = 0;
	public static int shots_taken;
	public string nextLevel;
	public string thisLevel;
	public int maxShots;
	public int toBreak;


	// Use this for initialization
	void Start () {
		pops = 0;
	}
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 1000, 200), "You have popped " + pops + "\\" + toBreak 
			+ "\nYou have " + shots_taken + "\\" + maxShots + " shots Availiable");
	}
	// Update is called once per frame
	void Update () {
		
		if (pops == toBreak) {
			shots_taken = 0;
			pops = 0;
			SceneManager.LoadScene (nextLevel);
		}
		if (maxShots == shots_taken) {
			shots_taken = 0;
			pops = 0;
			SceneManager.LoadScene (thisLevel);
			}

	}
	public void increment()
	{
		pops++;
	}


}
