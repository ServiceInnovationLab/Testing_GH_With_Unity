using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TestScript : MonoBehaviour
{
    Rigidbody body;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 50)
        {
            body.velocity = new Vector3(-1, 0, 0);
        }
        else
        {
            body.velocity = new Vector3(1, 0, 0);
        }
    }
}
