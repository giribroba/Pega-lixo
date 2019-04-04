using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    public float xMax, speed, speedC;
    float moviment;

    public static float força, speedCenario;

    void Start()
    {
        speedCenario = speedC;    
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
        transform.Translate(Vector3.right * speed * força * Time.deltaTime);
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
     

