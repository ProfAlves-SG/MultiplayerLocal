using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    public float speed = 5f;
    public float rotationSpeed = 125f;

    public Rigidbody rb;

    void Update()
    {
        float move = Input.GetAxis(horizontalInput);
        float turn = Input.GetAxis(verticalInput);

        Vector3 movement = transform.forward * move * speed * Time.deltaTime;
        transform.Rotate(0, turn * rotationSpeed * Time.deltaTime, 0);
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
