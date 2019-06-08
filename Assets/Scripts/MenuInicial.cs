
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public Text score;
    [SerializeField] string Cena;
    public static bool mute;
    [SerializeField] GameObject[] Audios;
    void Start()
    {
        Time.timeScale = 0;
    }
    public void ChamaCena()
    {
        SceneManager.LoadScene(Cena);
    }

    public void Mute()
    {
        MenuInicial.mute = !MenuInicial.mute;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        foreach (GameObject i in Audios)
        {
            i.GetComponent<AudioSource>().enabled = !mute;
        }
    }
}



