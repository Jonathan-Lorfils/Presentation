using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeplacementVaisseau : MonoBehaviour
{
    public GameObject explosionImpact;
    private Vector3 _vector3;
    private int speed = 10;

    // Update is called once per frame
    void Update()
    {
        _vector3 = transform.localPosition;
        _vector3.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.localPosition = _vector3;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Ennemy") || other.gameObject.tag.Equals("Laser"))
        {
            FindObjectOfType<AudioManager>().Play("AlienDies");
            Instantiate(explosionImpact, transform.position, transform.rotation);
            gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
}
