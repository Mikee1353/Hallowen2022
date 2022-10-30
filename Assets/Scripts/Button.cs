using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
