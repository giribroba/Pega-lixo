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
         var random = Random.Range(0, inimigos.Length);
        if(random == 2)
        {
            
        }
        else if(BarraO2.O2 > 0 )
        {
            Instantiate(inimigos[random], new Vector2(Random.Range(-xMin_max, xMin_max), 8),Quaternion.identity);
        }             
    }

}
