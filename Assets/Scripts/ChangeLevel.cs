using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour {
	public string Level;
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Contains ("Player")) {
			SceneManager.LoadScene (Level);
		}
	}
}
