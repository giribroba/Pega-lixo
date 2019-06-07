using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] string Cena;
    void Start()
    {
        Time.timeScale = 0;
    }
    public void ChamaCena()
    {
        SceneManager.LoadScene(Cena);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
