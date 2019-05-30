using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnomalyMover : MonoBehaviour
{

    Vector2 moveVector = new Vector2(-1f, 0f);
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveVector * speed * Time.deltaTime);
    }
}
