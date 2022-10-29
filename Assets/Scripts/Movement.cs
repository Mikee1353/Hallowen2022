using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
   
    private int speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 pos = transform.position;
            pos += transform.up * Time.deltaTime * speed;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 pos = transform.position;
            pos -= transform.up * Time.deltaTime * speed;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos += transform.right * Time.deltaTime * speed;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos -= transform.right * Time.deltaTime * speed;
            transform.position = pos;
        }
       

    }
     private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("deðdi");
    }
}
