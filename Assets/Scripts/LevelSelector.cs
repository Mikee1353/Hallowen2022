using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int sceneNumber;

        // Start is called before the first frame update
        void Start()
    {
        
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Level " + sceneNumber);
    }
}
