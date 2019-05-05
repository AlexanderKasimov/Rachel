using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float speed = 2f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(LoadSceneAsync());
        }
    }

    private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalMovement, 0);
        rb2d.AddForce(movement*speed*Time.deltaTime);
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
