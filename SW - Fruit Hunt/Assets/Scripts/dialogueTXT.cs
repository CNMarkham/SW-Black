using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTXT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if we're colliding (onTrigger) with C.N.M's collider
        if(collision.gameObject.tag == "Player" && gameObject.tag == "C.N.M")
        {

        }
    }
}
