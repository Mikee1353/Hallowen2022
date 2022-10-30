using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpoonAnimClick : MonoBehaviour
{
    public GameObject selectedObject;
    public Animator animator;

    private int entryNumber;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                animator.SetBool("Click", true);
            }
        }

        if(entryNumber == 3)
        {
            CallLoadNextScene();
        }
    }

    public void setBoolFalse()
    {
        animator.SetBool("Click", false);
        entryNumber++;
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
