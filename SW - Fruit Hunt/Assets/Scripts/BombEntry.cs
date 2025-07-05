using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BombEntry : MonoBehaviour
{
    public GameObject BombDefusal;
    public TextMeshProUGUI displayedTxt;
    public int[] code = { 0, 5, 2, 3 };
    public int counter;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if we're colliding with the gameObject with the tag "Bomb" and find the gameObject TimersCountdown, Rob dies.
        if(collision.gameObject.tag == "Bomb" && FindAnyObjectByType<TimersCountdown>().robDIED)
        {
            //BombDefusal will appear
            BombDefusal.SetActive(true);

        }
    }

    public void UpdateCode()
    {
        displayedTxt.text = string.Join("", code);

    }
    // Make the player unable to move when the BombDefusal is open
    // Make the text of the BombDefusal equal to "" when it opens up

    // Make a function to add digits into an array of strings, and that array will display on the bomb defusal text

    // Make a function to close the BombDefusal window? and add it to a button?(maybe) 
    public void Backspace()
    {
        code[counter] = 0;
        UpdateCode();
        if (counter == 0)
            return;
        counter--;

    }
    public void Keypad(int number)
    {
        code[counter] = number;
        UpdateCode();
        if (counter == 3)
            return;
        counter++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //if we're colliding with the gameObject with the tag "Bomb" and find the gameObject TimersCountdown, Rob dies.
        if (collision.gameObject.tag == "Bomb" && FindAnyObjectByType<TimersCountdown>().robDIED)
        {
            //BombDefusal will disappear
            BombDefusal.SetActive(false);

        }
    }
}
