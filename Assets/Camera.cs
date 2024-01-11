using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.U))
            verticalInput = 1f;
        else if (Input.GetKey(KeyCode.H))
            horizontalInput = -1f;
        else if (Input.GetKey(KeyCode.J))
            verticalInput = -1f;
        else if (Input.GetKey(KeyCode.K))
            horizontalInput = 1f;

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
