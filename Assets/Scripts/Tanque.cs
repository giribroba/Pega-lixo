using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    [SerializeField] Renderer cor;
    public static Color cors;
 
    void Start()
    {
        cors = new Color(0,1,0);
    }

    void Update()
    {
        cor.material.color = cors;
        if (BarraO2.O2 > 66)
        {
            cors.r = 0;
            cors.g = 1;
        }
        else if (BarraO2.O2 > 33)
        {
            cors.r = 1;
            cors.g = 1;
        }
        else
        {
            cors.g = 0;
            cors.r = 1;
        }
    }
}
