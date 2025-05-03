using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    public Vector3 direction;

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
            enemyHealth -= 10;
            //add his direction to his position
            direction = transform.position - collision.transform.position;
            //add direction to Rob's current position
            transform.position += direction * 2.3f;
            //if enemyHealth is below or equal to zero...
            if(enemyHealth <= 0)
            {
                //make Rob disappear.
                gameObject.SetActive(false);
                //make closedChest gameObject disappear
                //make openChest gameObject appear
                //make Watermelon gameObject appear
                //make the Watermelon's scroll appear
            }
        }
    }
}
