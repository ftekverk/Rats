using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    //1.) Movement
    public float jumpPower;
    public float runPower;
    bool isGrounded;
    // Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;


    [SerializeField]
    Transform groundCheck;


    //2.) Effects
    //public ParticleSystem dust;


    // Start is called before the first frame update
    void Start()
    {
        //    animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {

        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey("right"))
        {
            Right();
        }
        else if (Input.GetKey("left"))
        {
            Left();
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            if (isGrounded)
            {
                //  animator.Play("Player2_Idle");
            }

        }
        if (Input.GetKey("z") && isGrounded)
        {
            Jump();
        }

    }


    void Right()
    {
        rb2d.velocity = new Vector2(runPower, rb2d.velocity.y);
        if (isGrounded)
        {
            //  animator.Play("Player2_Run");
            spriteRenderer.flipX = true;
        }
    }


    void Left()
    {
        rb2d.velocity = new Vector2(-runPower, rb2d.velocity.y);
        if (isGrounded)
        {
            // animator.Play("Player2_Run");
            spriteRenderer.flipX = false;
        }
    }

    void Jump()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        // animator.Play("Player2_Jump");
    }



}
