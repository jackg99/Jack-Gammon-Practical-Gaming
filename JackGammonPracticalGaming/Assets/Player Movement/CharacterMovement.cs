using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    /// <summary>
    /// Speed at which player moves
    /// </summary>
    public float movementSpeed;

    // Use this for initialization
    void Start()
    {

        movementSpeed = 8f;

    }

    // Update is called once per frame
    void Update()

    {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"),Space.Self);

        //transform.Translate(movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        //moves character forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;

        }

        //moves character backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;

        }

        //moves character right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;

        }

        //moves character left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;

        }

    }
}

