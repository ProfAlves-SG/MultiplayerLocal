using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    public float speed = 5f;
    public float rotationSpeed = 125f;

    public Rigidbody rb;

    public float move;
    public float turn;
    public int score;
    
    void Update()
    {   
        move = Input.GetAxis(verticalInput);
        turn = Input.GetAxis(horizontalInput);
    }

    private void FixedUpdate()
    {
        Vector3 movement = transform.forward * move * speed;
        transform.Rotate(0, turn * rotationSpeed * Time.deltaTime, 0);
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("Coin"))
       {
            score++;
            Destroy(collision.gameObject);
       }
    }
}
