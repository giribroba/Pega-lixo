using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixes : MonoBehaviour
{
    [SerializeField] float speed; 
    void Update()
    {
        transform.translate(Vector3.Right * -Speed * Time.deltaTime);
    }
}
