using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ScriptEnnemie : MonoBehaviour
{
    public GameObject explosionImpact;
    private Vector3 _vector3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Balle"))
        {
            Score.valeurScore += 10;
            FindObjectOfType<AudioManager>().Play("AlienDies");
            Instantiate(explosionImpact, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
    
