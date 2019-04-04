using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class botão : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum tipo {L,R};
    public tipo botao;
    public float sensibility;

    bool pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        playerBehavior.força = 0;
    }

    void Update()
    {
        if (pressed)
        {
            switch (botao)
            {
                case tipo.L:
                    playerBehavior.força -= Time.deltaTime * sensibility;
                    playerBehavior.força = Mathf.Clamp(playerBehavior.força, -1, 0);
                    break;
                case tipo.R:
                    playerBehavior.força += Time.deltaTime * sensibility;
                    playerBehavior.força = Mathf.Clamp(playerBehavior.força, 0, 1);
                    break;
            }
        }
    }
}
