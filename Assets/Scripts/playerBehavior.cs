using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    float moviment;

    public float speed;

    void Update()
    {
        move();
    }

    void move()
    {
        moviment = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * moviment * speed * Time.deltaTime);
    }
}
