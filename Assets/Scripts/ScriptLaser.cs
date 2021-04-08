using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLaser : MonoBehaviour
{
    public int speed = 20;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
}
