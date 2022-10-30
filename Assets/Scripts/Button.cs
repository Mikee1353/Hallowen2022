using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        transform.position = new Vector2(transform.localPosition.x, -2.534f);
        CallLoadNextScene();
    }

    public void CallLoadNextScene()
    {
        Invoke("LoadNextScene", 1);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
