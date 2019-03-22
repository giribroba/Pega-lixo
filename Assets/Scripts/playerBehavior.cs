using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    public float xMax;
    float moviment;

    public float speed;

    void Start() 
    {
        transform.position = new Vector3(0, -4.9f);   
    }
    void Update()
    {
        move();
        limit();
    }

    /// <summary>
    /// Esta função controla o movimento do jogador
    /// </summary>
    void move()
    {
        moviment = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moviment * speed * Time.deltaTime);
    }

    /// <summary>
    /// Esta função limita o movimento do jogador pela tela
    /// </summary>
     void limit()
    {
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3 (xMax, transform.position.y);
        }
        if (transform.position.x < -xMax)
        {
            transform.position = new Vector3 (-xMax, transform.position.y);
        }
    }
}
