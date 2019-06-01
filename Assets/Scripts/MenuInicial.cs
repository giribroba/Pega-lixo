using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }
    public void ChamaJogo()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void Tutorial()
    {
        SceneManager.LoadScene("GameScene");  
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
