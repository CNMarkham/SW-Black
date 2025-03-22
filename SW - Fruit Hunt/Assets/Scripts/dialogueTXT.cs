using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CNMDialogueTXT : MonoBehaviour
{
    public GameObject CNMBox;
    public GameObject HelgaBox;

    public GameObject BobKidBox;
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
            //making CNM's dialogue box appear when we collide with the trigger
            CNMBox.SetActive(true);
        }
        //else
        //{
            //making CNM's dialogue box disappear when we don't collide the trigger
            //CNMBox.SetActive(false);
        //}

        //if we're colliding (onTrigger) with Helga's collider
        if(collision.gameObject.tag == "Player" && gameObject.tag == "Helga")
        {
            //making Helga's dialogue box appear when we collide with the trigger
            HelgaBox.SetActive(true);
        }

        if(collision.gameObject.tag == "Player" && gameObject.tag == "KidKidKidKinderSurprise")
        {
            BobKidBox.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        //if we leave the trigger
        if (collision.gameObject.tag == "Player" && gameObject.tag == "C.N.M")
        {
            //making the dialogue box disappear
            CNMBox.SetActive(false);
        }

        //if we leave the trigger
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Helga")
        {
            //making the dialogue box disappear
            HelgaBox.SetActive(false);
        }
    }
}
