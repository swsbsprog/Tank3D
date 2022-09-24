using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform tankTr;
    void Start()
    {
        tankTr = Tank.instance.transform;
    }

    void LateUpdate()
    {
        Vector3 lookAtPos = tankTr.position;
        lookAtPos.y = transform.position.y;
        transform.LookAt(lookAtPos);
    }
}
