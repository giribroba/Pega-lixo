using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoBehavior : MonoBehaviour
{
    public float speed;
    public int score; 

    void Start()    
    {
        transform.eulerAngles =new Vector3(transform.rotation.x, transform.rotation.y, lixoSpawn.rotacao);   
    }
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
        // transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            scoreCount.Count += score;
            Destroy(gameObject); 
        }  
    }
}
