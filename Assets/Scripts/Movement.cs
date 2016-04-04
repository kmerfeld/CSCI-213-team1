using UnityEngine;
using System.Collections;

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
        bool jmp2 = Input.GetButton("Horizontal");

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
            jmpmovement = 35f;
        }
        else
        {
            jmpmovement = 0f;
        }

        Vector2 movement = new Vector2(moveHorizontal, jmpmovement);
        
        rb2d.AddForce(movement * speed);
    }
}
