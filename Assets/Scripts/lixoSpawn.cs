using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoSpawn : MonoBehaviour
{    
    public float xMax;
    public float Y;
    public GameObject maca;
    public float CD;
    
    float cdTemp;
    void Update()
    {
        if (cdTemp <= 0)
        {
            float X = Random.Range (-xMax, xMax);
            Instantiate(maca, new Vector3 (X, Y), Quaternion.identity);
            cdTemp = CD;
        }
        cdTemp -= Time.deltaTime;
    }
}
