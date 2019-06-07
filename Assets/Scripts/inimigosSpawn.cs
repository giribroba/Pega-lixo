using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigosSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] inimigos;
    [SerializeField] float xMin_max;
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 2f);
    }
    
    void Spawn()
    {
        if(BarraO2.O2 > 0 )
        {
            Instantiate(inimigos[Random.Range(0, inimigos.Length+1)], new Vector2(Random.Range(-xMin_max, xMin_max), 8),Quaternion.identity);
        }  
    }

}
