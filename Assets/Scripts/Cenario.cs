using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public enum tipo {baixo, meio, topo};
    public tipo cenario;
    public GameObject meio, topo;

    void Update()
    {
        transform.Translate(Vector3.up * -playerBehavior.speedCenario * Time.deltaTime);
        if (transform.position.y < -13)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(meio, new Vector3(0, 14.1f), Quaternion.identity);
        }
    }
}
