using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMover : MonoBehaviour
{
    Vector2 startPosition;
    Vector2 moveVector = new Vector2(0f, 1f);

    public float speed = 2f;
    public GameObject endPlace;    


    private void Awake()
    {
        startPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position,endPlace.transform.position) < 0.05f )
        {
            moveVector = new Vector2(0f, -1f);
        }
        if (Vector2.Distance(transform.position, startPosition) < 0.05f)   
        {
            moveVector = new Vector2(0f, 1f);
        }

        transform.Translate(moveVector*speed*Time.deltaTime);
    }
}
