using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PremiereCoroutine());
    }
    
    IEnumerator PremiereCoroutine()
    {
        FindObjectOfType<AudioManager>().Play("Explosion");
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
