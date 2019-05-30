using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCount : MonoBehaviour
{
    [SerializeField] Text ScoreNumber;
    public static int Count;

    void Update()
    {
        ScoreNumber.text = Count.ToString();
    }
}
