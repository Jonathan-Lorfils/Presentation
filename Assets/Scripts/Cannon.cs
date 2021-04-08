using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform pointDeTire;
    public GameObject ballePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        FindObjectOfType<AudioManager>().Play("Missile");
        Instantiate(ballePrefab, pointDeTire.position, pointDeTire.rotation);
    }
}
