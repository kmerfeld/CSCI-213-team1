using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController_minigame : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	public string Level;
   // private GameObject slider;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;


	void Start ()
	{
		rb = GetComponent<Rigidbody>();

    }

	void FixedUpdate ()
	{
		//move left\right
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		rb.AddForce (movement * speed);

		//jump
		if (Input.GetButtonDown("Jump") && rb.transform.position.y < -8.6)
		{
			rb.AddForce (0, 700, 0);
		}
	}

	void Update ()
	{
		//cheap walls
		//keep player above ground
		if (rb.position.y < -10) {
			rb.AddForce (0, 200, 0);
		}
		//keep player inside arena
		if (rb.position.x > 19) {
			
			rb.AddForce (-1000, 0, 0);
		}
		if (rb.position.x < -34) {
			rb.AddForce (1000, 0, 0);
		}
		//fire bullets
        bool jmp1 = Input.GetButtonDown("Fire3");
        if (jmp1 && Time.time > nextFire)
		{
			
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

			GameLoop.shots_taken++;

		}
	}
    
}