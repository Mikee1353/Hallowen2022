using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public static bool selected = false;
        
   

    void Start()
    {
        
    }

   
    void Update()
    {
        

        if (selected)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
            Debug.Log(mousePos);
        }
        
    }
    private void OnMouseDown()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            
            selected = true;
        }
       
    }
    private void OnMouseUp()
    {
        selected = false;
    }
    



}