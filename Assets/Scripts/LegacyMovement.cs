using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegacyMovement : MonoBehaviour
{

    //Declare/initialise variables

    private float movementZ;
    private float movementY;
    private float movementX;

    public float speed = 0;
    public float jumpForce = 0;

    private Rigidbody rb;

    void Start()
    {
        //Initialise rigidbody
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        //Input

        if (Input.GetKey("w"))
        {
            movementZ = 1;
        }
        else if (Input.GetKey("s"))
        {
            movementZ = -1;
        }
        else if (Input.GetKey(name:"d"))
        {
            movementX = 1;
        }
        else if (Input.GetKey(name:"a"))
        {
            movementX = -1;
        }
        else
        {
            movementZ = 0;
            movementX = 0;
        }

    }

    private void FixedUpdate()
    {
        //Apply movement

        Vector3 movement = new Vector3(movementX, 0f, movementZ);
        rb.AddForce(movement * speed);
        movement = new Vector3(0f, movementY, 0f);

        //GroundCheck
        RaycastHit hit;


        //Cast raycast - (origin, direction, output, distance)
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1))
        {
            if (hit.transform.tag == "Ground")
            {
                rb.AddForce(movement * jumpForce);
            }
        }

    }
}
