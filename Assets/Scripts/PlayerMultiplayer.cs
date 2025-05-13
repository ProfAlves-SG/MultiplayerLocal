using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMultiplayer : MonoBehaviour
{
    //GD1SEXTA

    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    public float speed = 5f;
    public float rotationSpeed = 125f;

    public Rigidbody rb;

    public float move;
    public float turn;

    void Update()
    {
        // Pega os valores quando apertamos o bot�o w/s ou setinha cima/setinha baixo
        // e guarda na vari�vel move
        move = Input.GetAxis(verticalInput);

        // Faz o mesmo, por�m com os bot�es a/d ou setinha esquerda/setinha direita
        turn = Input.GetAxis(horizontalInput);
        
        Debug.Log("Horizontal" + move);
        Debug.Log("Vertical" + turn);
    }
}
