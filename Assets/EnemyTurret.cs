using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public Missile missile;
    public Transform firePoint;
    public void Fire()
    {
        Instantiate(missile, firePoint.position, transform.rotation);
    }
}
