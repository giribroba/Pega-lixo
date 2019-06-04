using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coraisSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] corais;
    [SerializeField] float[] xMin_max;
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 1f);
    }
    
    void Spawn()
    {
        Instantiate(corais[Random.Range(0, corais.Length+1)], new Vector2(xMin_max[Random.Range(0, 2)],6),Quaternion.identity);
    }
}
