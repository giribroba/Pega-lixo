using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botões_P_menu : MonoBehaviour
{
    [SerializeField]RectTransform gaveta, pause;
    [SerializeField]float gSpeed;

    public void Pause()
    {
        if (Time.timeScale == 0)
        {
            AbrirGaveta();
            Time.timeScale = 1;
        }
        else
        {
            AbrirGaveta();
            Time.timeScale = 0;
        }
    }

    void AbrirGaveta()
    {
        if (Time.timeScale == 1)
        {
            gaveta.anchoredPosition = new Vector2(pause.anchoredPosition.x, gaveta.anchoredPosition.y);
        }
        else
        {
            gaveta.anchoredPosition = new Vector2(234, gaveta.anchoredPosition.y);
        }
    }
}
