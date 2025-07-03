using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEntry : MonoBehaviour
{
    public GameObject BombDefusal;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if we're colliding with the gameObject with the tag "Bomb" and find the gameObject TimersCountdown, Rob dies.
        if(collision.gameObject.tag == "Bomb" && FindAnyObjectByType<TimersCountdown>().robDIED)
        {
            //BombDefusal will appear
            BombDefusal.SetActive(true);

        }
    }
    // Make the player unable to move when the BombDefusal is open
    // Make the text of the BombDefusal equal to "" when it opens up

    // Make a function to add digits into an array of strings, and that array will display on the bomb defusal text

    // Make a function to close the BombDefusal window? and add it to a button?(maybe) 
}
