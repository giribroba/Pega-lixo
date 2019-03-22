﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class macaBehavior : MonoBehaviour
{
    public float speed; 
    void Update()
    {
        cair();  
    }
    void cair()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject); 
        }  
    }
}
