using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouseCursor : MonoBehaviour
{
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        Plane plane = new Plane(Vector3.up, transform.position.y);
        plane.Raycast(ray, out var distance);
        Vector3 hitPos = ray.origin + ray.direction * distance;
        Vector3 lookAtPos = hitPos;
        lookAtPos.y = transform.position.y;
        transform.LookAt(lookAtPos);
    }
}
