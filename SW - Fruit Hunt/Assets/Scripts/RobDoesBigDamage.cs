using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobDoesBigDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rob")
        {
            Debug.Log("You just lost health for your dumb mistake");
        }
    }
}
