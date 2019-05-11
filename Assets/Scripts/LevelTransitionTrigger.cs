using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitionTrigger : MonoBehaviour
{
    public string levelName = "Farm_";

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
            StartCoroutine(LoadSceneAsync());
        }
    }

    IEnumerator LoadSceneAsync()
    {
        Debug.Log("Start loading");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelName);
        while (!asyncLoad.isDone)
        {
            yield return null;
            Debug.Log("Loaded");
        }
    }
}
