
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botões_P_menu : MonoBehaviour
{
    [SerializeField] RectTransform gaveta, pause;
    [SerializeField] float gSpeed;
    [SerializeField] GameObject[] Audios;
    [SerializeField] Sprite[] muteSprites;
    [SerializeField] Image mute;
    void Start()
    {
        Time.timeScale = 1;
        scoreCount.Count = 0;
    }
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
    public void Mute()
    {
        MenuInicial.mute = !MenuInicial.mute;
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

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        foreach(GameObject i in Audios)
        {
            i.GetComponent<AudioSource>().enabled = !MenuInicial.mute;
        }
        mute.sprite = muteSprites[(MenuInicial.mute) ? 1 : 0];
    }
}
