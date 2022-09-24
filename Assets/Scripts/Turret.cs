using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Missile missile;
    public Transform firePoint;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(missile, firePoint.position, transform.rotation);
        }
    }
}
