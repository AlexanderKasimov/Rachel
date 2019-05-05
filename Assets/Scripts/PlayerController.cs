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

    public float velocity;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(LoadSceneAsync());
        }
        animator.SetFloat("Speed", rb2d.velocity.magnitude);

    }

    private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalMovement, 0);
        rb2d.AddForce(movement*speed*Time.deltaTime);
        velocity = rb2d.velocity.normalized.x;

        if (horizontalMovement < 0)
        {
            sr.flipX = true;
        }
        if (horizontalMovement > 0)
        {
            sr.flipX = false;
        }


    }

    IEnumerator LoadSceneAsync()
    {
        Debug.Log("Start loading");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Farm_02");
        while (!asyncLoad.isDone)
        {            
            yield return null;
            Debug.Log("Loaded");
        }   
    }



}
