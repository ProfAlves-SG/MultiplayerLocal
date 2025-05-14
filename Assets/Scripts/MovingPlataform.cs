using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour
{
    public Transform pointStart;
    public Transform pointEnd;
    public Transform plataform;
    public float speed = 3f;

    private Transform target;

    private void Start()
    {
        target = pointEnd;
    }

    private void Update()
    {
        plataform.position = Vector3.MoveTowards(plataform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == pointStart)
            {
                target = pointEnd;
            }
            else
            {
                target = pointStart;
            }
        }
    }

    void OnTriggerEnter(Collider colision)
    {
        if (colision.CompareTag("Player"))
        {
            colision.transform.parent = plataform.transform;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }

}