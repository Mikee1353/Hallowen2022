using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TulumbaScript : MonoBehaviour
{
    [SerializeField] int clickCount;
    public GameObject EmptyGlass;
    public GameObject FullGlass;
    public GameObject selectedObject;
    
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                clickCount++;
            }
        }

        if (clickCount > 10)
        {
            CallLoadNextScene();
        }

        if(clickCount == 5)
        {
            EmptyGlass.SetActive(false);
            FullGlass.SetActive(true);
        }
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
