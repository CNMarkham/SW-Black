using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEntry : MonoBehaviour
{
    public GameObject BombDefusal;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bomb" && FindAnyObjectByType<TimersCountdown>().robDIED)
        {
            BombDefusal.SetActive(true);

        }
    }
}
