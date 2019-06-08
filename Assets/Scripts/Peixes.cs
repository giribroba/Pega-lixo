using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixes : MonoBehaviour
{
    [SerializeField] float speed, yMin; 
    void Update()
    {
        transform.Translate(Vector3.right * -speed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x, transform.position.y - (playerBehavior.speedCenario) * Time.deltaTime);
        if (transform.position.y < yMin)
        {
            Destroy(gameObject);
        }
    }
}
