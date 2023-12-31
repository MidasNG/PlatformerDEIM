using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private float idleTime = 0f;
    [SerializeField] private float speed= 5f;
    private bool jumpReady, controllable = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (!animator.GetBool("runBool")) idleTime += Time.deltaTime;

        if (idleTime >= 5f) 
        {
            animator.SetBool("longIdleBool", true);
        }

        if (Input.GetAxisRaw("Horizontal") < 0f && controllable) { spriteRenderer.flipX = true; animator.SetBool("runBool", true); IdleReset(); }
        else if (Input.GetAxisRaw("Horizontal") > 0f && controllable) { spriteRenderer.flipX = false; animator.SetBool("runBool", true); IdleReset(); }
        if (rb.velocity.x == 0) animator.SetBool("runBool", false);

        if (controllable) rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && jumpReady && controllable)
        {
            rb.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
            animator.SetBool("jumpBool", true);
        }
    }

    private void IdleReset()
    {
        idleTime = 0f;
        animator.SetBool("longIdleBool", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.velocity.y == 0)
        {
            jumpReady = true;
            animator.SetBool("jumpBool", false);
            IdleReset();
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (rb.velocity.y == 0) jumpReady = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jumpReady = false;
    }

    public void StopControl()
    {
        controllable = false;
    }
}
