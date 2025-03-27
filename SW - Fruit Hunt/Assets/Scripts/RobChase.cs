using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobChase : MonoBehaviour
{
    public float speed;

    public Vector3 RobMoveDirection;

    public GameObject Rob;
    public GameObject PlayE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RobMoveDirection = PlayE.transform.position - transform.position;

        Rigidbody2D hazardrigidBody = Rob.GetComponent<Rigidbody2D>();
        hazardrigidBody.velocity = RobMoveDirection.normalized * speed;
    }
}
