
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour {

    public int HighScore;
    public static int recorde; 

    [Serializable]
    class DadosDoJogo
    {
        public int Int;
        public bool mute;
    }

    public void Save()
    {
        BinaryFormatter binario = new BinaryFormatter();
        FileStream arquivo = File.Create(Application.persistentDataPath + "/Save.DAT");
        DadosDoJogo dados = new DadosDoJogo(); 
        dados.Int = HighScore;
        dados.mute = MenuInicial.mute;

        binario.Serialize(arquivo, dados);
        arquivo.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Save.DAT") == true)
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream arquivo = File.Open(Application.persistentDataPath + "/Save.DAT", FileMode.Open);
            DadosDoJogo dados = (DadosDoJogo)binario.Deserialize(arquivo);

            HighScore = dados.Int;
            MenuInicial.mute = dados.mute;

            arquivo.Close();
        }
    }

    void Update ()
    {
        GetComponent<MenuInicial>().score.text = ("Recorde: " + HighScore.ToString());
        Load();
        if (recorde > HighScore)
        {
            HighScore = recorde;
            Save();
        }
        playerBehavior.hgScore = HighScore; 
    }
}
