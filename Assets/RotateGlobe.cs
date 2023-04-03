using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGlobe : MonoBehaviour
{
    float rotationSpeed = 10f;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.down, mouseX * rotationSpeed, Space.World);
            transform.Rotate(Vector3.right, mouseY * rotationSpeed, Space.World);
        }
    }
}
