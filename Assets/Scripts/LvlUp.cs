using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(this.gameObject.transform.position.x > 3)
        {
            Movement.selected = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "engel")
        {
            Destroy(this.gameObject);
        }
    }
        
}
