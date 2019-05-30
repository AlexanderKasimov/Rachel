using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMover : MonoBehaviour
{
    Vector2 startPosition;
    Vector2 moveVector = new Vector2(0f, 1f);
    bool isFirstTime = true;
    float speed;

    public float startSpeed = 2f;
    public float endSpeed = 1f;
    public GameObject startPlace;
    public GameObject endPlace;
    public GameObject anomaly;
    public GameObject transition;




    private void Awake()
    {
        startPosition = transform.position;
        speed = startSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivateAnomaly", 3.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position,endPlace.transform.position) < 0.05f )
        {
            moveVector = (startPlace.transform.position - endPlace.transform.position).normalized;
            isFirstTime = false;
            speed = endSpeed;            
        }
        if (Vector2.Distance(transform.position, startPlace.transform.position) < 0.05f && !isFirstTime)   
        {
            moveVector = -moveVector;
            
        }   
            
           

        transform.Translate(moveVector*speed*Time.deltaTime);
    }

    void ActivateAnomaly()
    {
        anomaly.SetActive(true);
        enabled = false;
        transition.SetActive(true);
    }

}
