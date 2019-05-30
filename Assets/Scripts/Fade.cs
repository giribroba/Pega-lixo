using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] float sensibilidade, midOpa;
    [SerializeField] Image fade;
    Color tempColor;

    void Start()
    {
        tempColor = fade.color;
        tempColor.a = 0.75f;
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            fade.color = new Color(fade.color.r, fade.color.g, fade.color.b, 0.7f);
        }
        else
        {
            fade.color = tempColor;
            tempColor.a -= ((fade.color.a > midOpa) ? sensibilidade * Time.deltaTime : 0);
        }  
    }
}
