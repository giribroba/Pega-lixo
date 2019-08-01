using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peixesSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] peixes;
    [SerializeField] float yMax;
    void Start()
    {
        InvokeRepeating("Spawn",0, 1.5f);
    }
    void Spawn()
    {
        Instantiate(peixes[Random.Range(0, peixes.Length)], new Vector2(3.8f, Random.Range(-3, yMax)), Quaternion.identity);
    }
}
