using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mBehavior : MonoBehaviour
{  
    public float speed; 
    void Start()
    {
        
    }
    void Update()
    {
        cair();   
    }
    void cair()
    {
        //transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    
}
