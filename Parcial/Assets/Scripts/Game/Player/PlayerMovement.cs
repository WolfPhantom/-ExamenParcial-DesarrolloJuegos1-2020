using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D body;

    void Awake()
    {

        body = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            body.velocity = new Vector2(-5, 0);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            body.velocity = new Vector2(5, 0);
        }
        else
        {
            body.velocity = new Vector2(0, 0);
        }
    }
}

