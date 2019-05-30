using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    [SerializeField] enum tipo {baixo, meio, topo};
    [SerializeField] tipo cenario;
    [SerializeField] GameObject meio, topo;
    [SerializeField] float yMin, ySpawn;


    void Update()
    {
        transform.Translate(Vector3.up * -playerBehavior.speedCenario * Time.deltaTime);
        if (transform.position.y < yMin)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(meio, new Vector3(0, ySpawn), Quaternion.identity);
        }
    }
}
