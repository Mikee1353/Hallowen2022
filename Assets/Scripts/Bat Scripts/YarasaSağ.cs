using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YarasaSağ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector3.left * Time.deltaTime);
    }
}
