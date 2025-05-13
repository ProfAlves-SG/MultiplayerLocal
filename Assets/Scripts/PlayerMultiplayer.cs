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
        // Pega os valores quando apertamos o botão w/s ou setinha cima/setinha baixo
        // e guarda na variável move
        move = Input.GetAxis(verticalInput);

        // Faz o mesmo, porém com os botões a/d ou setinha esquerda/setinha direita
        turn = Input.GetAxis(horizontalInput);
        
        Debug.Log("Horizontal" + move);
        Debug.Log("Vertical" + turn);
    }
}
