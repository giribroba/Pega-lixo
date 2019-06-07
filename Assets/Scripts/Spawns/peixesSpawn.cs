using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peixesSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] peixes;
    [SerializeField] float yMax;
    private int lado;//1 = Direita, 0 = Esquerda
    void Start()
    {
        InvokeRepeating("Spawn",0, 1.5f);
    }
    void Spawn()
    {
        //lado = Random.Range(0,2);
        lado = 1;
        if (lado == 0)
        {
            Instantiate(peixes[Random.Range(0, peixes.Length + 1)], new Vector2(-3.8f, Random.Range(-3, yMax)), Quaternion.identity);
        }
        else
        {
            Instantiate(peixes[Random.Range(0, peixes.Length + 1)], new Vector2(3.8f, Random.Range(-3, yMax)), Quaternion.identity);
        }
    }
}
