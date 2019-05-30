using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnomalyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.enabled = false;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            StartCoroutine(LoadSceneAsync());
        }
    }


    IEnumerator LoadSceneAsync()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Start loading");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Farm_01");
        while (!asyncLoad.isDone)
        {
            yield return null;
            Debug.Log("Loaded");
        }
    }



}
