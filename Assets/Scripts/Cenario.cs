using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    enum tipo {baixo, meio, topo};
    [SerializeField] tipo cenario;
    [SerializeField] GameObject meio, topo;
    [SerializeField] float yMin, ySpawn;
    GameObject player;
    bool fim;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        fim = false;
    }
    void Update()
    {
        transform.Translate(Vector3.up * -playerBehavior.speedCenario * Time.deltaTime);

        if (BarraO2.O2 <= 0 && !fim)
        {
            playerBehavior.speedCenario *= 2;          
            fim = !fim;
        }
        if (transform.position.y < yMin)
        {
            Destroy(gameObject);
        }
        if (cenario == tipo.topo && transform.position.y <= -7.72f)
        {
            player.GetComponent<playerBehavior>().GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (BarraO2.O2 > 0)
            {
                Instantiate(meio, new Vector3(0, ySpawn), Quaternion.identity);
            }
            else
            {
                Instantiate(topo, new Vector3(0, ySpawn - 1), Quaternion.identity);
            }
            
        }
    }
}
