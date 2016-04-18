using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour {
	public string Level;
	void OnCollisionEnter2D(Collision2D coll)
	{
		SceneManager.LoadScene (Level);

	}
}
