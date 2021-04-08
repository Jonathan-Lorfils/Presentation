using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class DeplacementEnnemies : MonoBehaviour
{
    public GameObject Laser; 
    private Boolean direction = true; 
    public List<GameObject> ennemiesList = new List<GameObject>();
    private Vector3 VectorH = new Vector3(1, 0, 0);
    private Vector3 VectorV = new Vector3(0, 0.2f, 0);
    private const double MAXDROITE = 10;
    private const double MAXGAUCHE = -10;
    public float speed = 1;
    
    void Start()
    {
        foreach (GameObject alien in GameObject.FindGameObjectsWithTag("Ennemy"))
        {
            ennemiesList.Add(alien);
        }
        InvokeRepeating("DeplacementAliens",0.5f,0.5f);
        InvokeRepeating("TireAleatoire", 1f,1f);
    }

    void DeplacementAliens()
    {
        if (ennemiesList.Count > 0)
        {
            Deplacement();
            Direction();
        }
        else
        {
            SceneManager.LoadScene("Victoire");
        }
    }

    void Deplacement()
    {
        for (int j = 0; j < ennemiesList.Count; j++)
        {
            if (ennemiesList[j].activeInHierarchy) 
            {
                if (ennemiesList[j].transform.localPosition.x > MAXDROITE)
                {
                    Descendre();
                    direction = false;
                } 
                if (ennemiesList[j].transform.localPosition.x < MAXGAUCHE)
                {
                    Descendre();
                    direction = true;
                }
                if (ennemiesList[j].transform.position.y <= -5)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
            else
            {
                ennemiesList.Remove(ennemiesList[j]);
            }
        }
    }

    void Direction() 
    {
        for (int x = 0; x < ennemiesList.Count; x++)
        {
            if (ennemiesList[x].activeInHierarchy) 
            {
                if (direction)
                {
                    ennemiesList[x].transform.position += VectorH * speed;
                }
                else
                {
                    ennemiesList[x].transform.position -= VectorH * speed;
                }
            }
        }
    }
    
    void Descendre() 
    {
        speed += 0.15f;
        for (int x = 0; x < ennemiesList.Count; x++) 
        {
            if (ennemiesList[x].activeInHierarchy) 
            {
                if (ennemiesList[x].activeInHierarchy) 
                {
                    ennemiesList[x].transform.position -= VectorV;
                }
            }
        } 
    }
    
    void TireAleatoire()
    {
        if (ennemiesList.Count > 0)
        {
            Vector3 posTire = ennemiesList[Random.Range(0, ennemiesList.Count)].transform.position;
            Instantiate(Laser, posTire, Quaternion.identity);
        }
    }
}
