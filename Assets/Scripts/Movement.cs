using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    private Animator animator;
    private Rigidbody2D rb2d;
    public float speed;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float jmpmovement;
        bool jmp1 = Input.GetButtonDown("Jump");
		//The next line isnt used, so i commented it
        //bool jmp2 = Input.GetButton("Horizontal");
	

        if(moveHorizontal != 0)
        {
            animator.SetTrigger("Playermoves");
        }
        else
        {
            animator.SetTrigger("Playerstops");
        }

        if (jmp1.Equals(true))
        {
			SceneManager.LoadScene ("Scenes/minigame");
            jmpmovement = 100f;
        }
        else
        {
            jmpmovement = 0f;
        }

        Vector2 movement = new Vector2(moveHorizontal, jmpmovement);
        
        rb2d.AddForce(movement * speed);
    }

	void update()
	{
		bool z = Input.GetButtonDown("fire1");
		if (z) 
		{
			
			SceneManager.LoadScene ("minigame");
		}

	}

}