using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float movementSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = CalculateDirection();
        transform.Translate(direction * movementSpeed * Time.deltaTime);

        //------------------Code for Zooming Out--------------------
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 40f)
            {
                Camera.main.fieldOfView += 2;
            }

            if (Camera.main.orthographicSize <= 50)
            {
                Camera.main.orthographicSize += 0.5f;
            }
        }

        //----------------Code for Zooming In-----------------------
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 20f)
            {
                Camera.main.fieldOfView -= 2;
            }

            if (Camera.main.orthographicSize >= 10)
            {
                Camera.main.orthographicSize -= 0.5f;
            }
        }
    }

    public Vector3 CalculateDirection()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction.y += 1.0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= 1.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction.y -= 1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction.x += 1.0f;
        }

        return direction.normalized;
    }
}
