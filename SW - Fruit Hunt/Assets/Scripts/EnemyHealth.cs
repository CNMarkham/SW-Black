using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    public Vector3 direction;
    public GameObject closedChest;
    public GameObject openChest;
    public GameObject watermelon;
    public GameObject watermelonScroll;

    // Start is called before the first frame update
    void Start()
    {
        //set enemyHealth to 100
        enemyHealth = 100;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if the gameObject Rob's colliding with's tag is "Pineapple"
        if(collision.gameObject.tag == "Pineapple")
        {

            //Minus 10 from enemyHealth.
            enemyHealth -= 20;
            //add his direction to his position
            direction = transform.position - collision.transform.position;
            //add direction to Rob's current position
            transform.position += direction * 2.3f;
            //if enemyHealth is below or equal to zero...
            if(enemyHealth <= 0)
            {
                FindAnyObjectByType<TimersCountdown>().robDIED = true;
                //make Rob disappear.
                gameObject.SetActive(false);
                //make closedChest gameObject disappear
                closedChest.SetActive(false);
                //make openChest gameObject appear
                openChest.SetActive(true);
                //make Watermelon gameObject appear
                watermelon.SetActive(true);
                //make the Watermelon's scroll appear
                watermelonScroll.SetActive(true);
            }
        }
    }
}
