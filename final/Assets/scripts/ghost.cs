using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    //[SerializeField] private flaot speed;

    public int speed = 10 ;

    private Rigidbody2D GhostBody;

    private void Awake()
    {
        GhostBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        GhostBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, GhostBody.velocity.x );

        GhostBody.velocity = new Vector2(GhostBody.velocity.x, Input.GetAxis("Vertical") * speed );

    }
}

