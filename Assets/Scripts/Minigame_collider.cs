using UnityEngine;
using System.Collections;

public class Minigame_collider : MonoBehaviour {
	//public Game other;

    void OnCollisionEnter(Collision col)
    {
    	Destroy(gameObject);
		GameLoop.pops++;
    }

		
}
