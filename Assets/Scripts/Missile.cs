using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public ParticleSystem explosion;
    private void OnTriggerEnter(Collider other)
    {
        var newExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
        newExplosion.Play();

        Destroy(newExplosion.gameObject, newExplosion.main.duration);
        Destroy(gameObject);
    }
}
