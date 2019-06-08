
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour {

    public int HighScore;
    public static int recorde; 
    public string DiretorioDoArquivo;
    public string FormatoDoArquivo;
    public string NomeDoArquivo;

    [Serializable]
    class DadosDoJogo
    {
        public int Int;
        public float Float;
        public string String;
        public bool Bool;
    }

    public void Save()
    {
        BinaryFormatter binario = new BinaryFormatter();
        FileStream arquivo = File.Create(DiretorioDoArquivo);
        DadosDoJogo dados = new DadosDoJogo(); 
        dados.Int = HighScore;

        binario.Serialize(arquivo, dados);
        arquivo.Close();
    }

    public void Load()
    {
        if (File.Exists(DiretorioDoArquivo) == true)
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream arquivo = File.Open(DiretorioDoArquivo, FileMode.Open);
            DadosDoJogo dados = (DadosDoJogo)binario.Deserialize(arquivo);

            HighScore = dados.Int;
            arquivo.Close();
        }
    }

    void Update ()
    {
        DiretorioDoArquivo = Application.persistentDataPath + "/" + NomeDoArquivo + "." + FormatoDoArquivo;
        GetComponent<MenuInicial>().score.text = HighScore.ToString();
        Load();
        if (recorde > HighScore)
        {
            HighScore = recorde;
            Save();
        }
        playerBehavior.hgScore = HighScore; 
    }
}
