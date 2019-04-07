using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class botão : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum tipo {L,R};
    public tipo botao;
    public float sensibility;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (botao == tipo.L)
        {
            playerBehavior.pressedL = true;
        }
        if (botao == tipo.R)
        {
            playerBehavior.pressedR = true;
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (botao == tipo.L)
        {
            playerBehavior.pressedL = false;
        }
        if (botao == tipo.R)
        {
            playerBehavior.pressedR = false;
        }
        playerBehavior.força = 0;
    }

    void Update()
    {
        if (playerBehavior.pressedL && playerBehavior.pressedR)
        {
            playerBehavior.força = 0;
        }
        else if(playerBehavior.pressedL)
        {
            playerBehavior.força -= sensibility * Time.deltaTime;
            playerBehavior.força = Mathf.Clamp(playerBehavior.força, -1, 0);
        }
        else if (playerBehavior.pressedR)
        {
            playerBehavior.força += sensibility * Time.deltaTime;
            playerBehavior.força = Mathf.Clamp(playerBehavior.força, 0, 1);
        }
    }
}
