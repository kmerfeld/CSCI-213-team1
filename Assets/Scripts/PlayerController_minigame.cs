using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController_minigame : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	public string Level;


	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	public int maxShots;
	private int shots_taken;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		rb.AddForce (movement * speed);
	}

	void Update ()
	{
        bool jmp1 = Input.GetButtonDown("Jump");
        if (jmp1 && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

			shots_taken++;
			if (maxShots == shots_taken) {
				SceneManager.LoadScene (Level);
			}
		}
	}
}