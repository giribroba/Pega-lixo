using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2Behaviour : MonoBehaviour
{
    [SerializeField] float speed;
    public static Renderer tanque;
    void Update()
    {
        cair();
        destroir();
    }

    void destroir()
    {
        if (transform.position.y <= -5.8f)
        {
            Destroy(gameObject);
        }
    }

    void cair()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && BarraO2.O2 > 0)
        {
            speed = 5;
            GetComponent<Animator>().SetBool("Estourou", true);
            BarraO2.O2 += 10;
            Destroy(gameObject, 0.3f);
        }
        if (other.tag == "Limit")
        {
            Destroy(gameObject);
        }
    }

}
