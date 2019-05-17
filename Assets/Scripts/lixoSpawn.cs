using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoSpawn : MonoBehaviour
{    
    [SerializeField] float xMax;
    [SerializeField] float Y;
    [SerializeField] GameObject lata, colher, caixa, copo, garrafa, lampada;
    [SerializeField] float CD;
    
    public static float rotacao;

    float cdTemp, X, tipo;

    void Update()
    {
        tipo = Random.Range (0,7);
        if (cdTemp <= 0)
        {
            X = Random.Range (-xMax, xMax);
            rotacao = Random.Range(-1, 360);
            switch (tipo)
            {
                case 1:
                    Instantiate(lata, new Vector3 (X, Y), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(colher, new Vector3 (X, Y), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(caixa, new Vector3 (X, Y), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(copo, new Vector3 (X, Y), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(garrafa, new Vector3 (X, Y), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(lampada, new Vector3 (X, Y), Quaternion.identity);
                    break;
            }
            cdTemp = CD;
        }
        cdTemp -= Time.deltaTime;
    }
}
