using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForKaristirma : MonoBehaviour
{
    private bool tut;

    private void Update()
    {
        if (tut)
        {
            Vector3 mouse;
            mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            this.gameObject.transform.rotation = Quaternion.AngleAxis(mouse.x,Vector3.back);

        }
        
    }
    private void OnMouseDown()
    {
        tut = true;
        Cursor.visible = false;
        
    }
    private void OnMouseUp()
    {
        tut = false;
        Cursor.visible = true;
        
    }
}
