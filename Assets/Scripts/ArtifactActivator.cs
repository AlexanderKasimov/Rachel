using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactActivator : MonoBehaviour
{
    public GameObject artifact;

    bool activated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !activated)
        {
            artifact.GetComponent<DiamondMover>().enabled = true;
            activated = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
