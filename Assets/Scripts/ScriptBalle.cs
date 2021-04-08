using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBalle : MonoBehaviour
{
    public int speed = 20;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Ennemy"))
        {
            Destroy(gameObject);
        }
        
    }
}
