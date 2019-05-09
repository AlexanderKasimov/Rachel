using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float speed = 2f;

    private Animator animator;
    private SpriteRenderer sr;

    private Vector2 movementDir;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        animator.SetFloat("Speed", movementDir.magnitude);
    }

    private void FixedUpdate()
    {
        //Get Input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        movementDir = new Vector2(horizontalInput, verticalInput).normalized;

        //Move player
        rb2d.MovePosition(rb2d.position + movementDir * speed * Time.fixedDeltaTime);        
    
        //Sprite Rotation
        if (movementDir.x < 0)
        {
            sr.flipX = true;
        }
        if (movementDir.x > 0)
        {
            sr.flipX = false;
        }
    }




}
