using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    RigidBody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<RigidBody>().velocity = new Vector3(0, 5, 0);
        }
        if (Input.GetKey("D"))
        {
            GetComponent<RigidBody>().velocity = new Vector3(0, 0, 1);
        }
        if (Input.GetKey("A"))
        {
            GetComponent<RigidBody>().velocity = new Vector3(0, 0, -1);
        }
        if (Input.GetKey("W"))
        {
            GetComponent<RigidBody>().velocity = new Vector3(1, 0, 0);
        }
    }
}