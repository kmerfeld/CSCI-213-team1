using UnityEngine;
using System.Collections;

public class Minigame_collider : MonoBehaviour {
	public object s;
    void OnCollisionEnter(Collision col)
    {
    	Destroy(gameObject);
    }
}
