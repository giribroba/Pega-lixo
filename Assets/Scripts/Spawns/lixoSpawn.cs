using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoSpawn : MonoBehaviour
{    
    [SerializeField] float xMax;
    [SerializeField] float Y;
    [SerializeField] GameObject lata, colher, caixa, copo, garrafa, lampada, O2, copoSB, canudoA, canudoL;
    [SerializeField] float CD, O2CD;
    
    public static float rotacao;

    float cdTemp, X, tipo,O2Temp;

    void Start()
    {
        cdTemp = CD;
        O2Temp = O2CD;
    }
    void Update()
    {
        X = Random.Range (-xMax, xMax);
        tipo = Random.Range (0,10);
        if (cdTemp <= 0)
        {            
            rotacao = Random.Range(-1, 360);
            if (BarraO2.O2 > 0)
            {
                switch (tipo)
                {
                    case 1:
                        Instantiate(lata, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(colher, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(caixa, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(copo, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(garrafa, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(lampada, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(canudoL, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(canudoA, new Vector3(X, Y), Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(copoSB, new Vector3(X, Y), Quaternion.identity);
                        break;
                }
            }
            cdTemp = CD;
        }
        if (O2Temp <= 0 && BarraO2.O2 > 0)
        {
            Instantiate(O2, new Vector3(X, Y), Quaternion.identity);
            O2Temp = O2CD;
        }
        cdTemp -= Time.deltaTime;
        O2Temp -= Time.deltaTime;
    }
}
