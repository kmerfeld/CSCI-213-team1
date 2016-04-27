using UnityEngine;
using System.Collections;

public class Mob_spawner : MonoBehaviour {
	public GameObject mob;
	public Transform mobSpawn;
	private float nextFire;
	public float fireRate;

	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(mob, mobSpawn.position, mobSpawn.rotation);


		}
	}
}
