using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Mouse X") * 1.5f;
            float y = Input.GetAxis("Mouse Y") * 1.5f;
            //Cursor.lockState = CursorLockMode.Locked;
            transform.eulerAngles += new Vector3(-y, x, 0);
        }
        else
        {
            //Cursor.lockState = CursorLockMode.None;
        }
    }
}
