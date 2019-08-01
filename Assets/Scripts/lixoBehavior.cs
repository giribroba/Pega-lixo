using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoBehavior : MonoBehaviour
{
    enum tipo {lixo, inimigo}
    [SerializeField] float speed;
    [SerializeField] int score;
    [SerializeField] tipo objeto;
    GameObject Personagem;

    void Start()    
    {
        Personagem = GameObject.FindWithTag("Player");
        if (objeto == tipo.lixo)
        {
            transform.eulerAngles =new Vector3(transform.rotation.x, transform.rotation.y, lixoSpawn.rotacao); 
        }      
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
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && objeto == tipo.lixo)
        {
            scoreCount.Count += score;
            Destroy(gameObject); 
        }
        else if (other.tag == "Player" && objeto == tipo.inimigo)
        {
            GetComponent<CapsuleCollider2D>().enabled = false;
            Personagem.GetComponent<playerBehavior>().perderVida();
            GetComponent<Animator>().SetBool("sumindo", true);
            speed /= 2;
            Destroy(gameObject, 0.5f);
        }
    }
}
