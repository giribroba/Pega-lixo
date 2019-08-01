
using UnityEngine;

public class lixoSpawn : MonoBehaviour
{    
    [SerializeField] float xMax;
    [SerializeField] float Y;
    [SerializeField] GameObject[] lixo;
    [SerializeField] GameObject O2;
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
        if (cdTemp <= 0)
        {            
            rotacao = Random.Range(-1, 360);
            if (BarraO2.O2 > 0)
            {
                Instantiate(lixo[Random.Range(0, lixo.Length)], new Vector3(X, Y), Quaternion.identity);
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
