using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }
    public void ChamaJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    
    public void Tutorial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        
    }
}
