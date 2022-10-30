using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YarasaSol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector3.right * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CallLoadNextScene();
    }
    public void CallLoadNextScene()
    {
        Invoke("LoadNextScene", 0);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
