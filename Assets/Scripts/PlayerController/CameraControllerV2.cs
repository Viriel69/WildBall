using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerV2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float sensitivity = 3;
    private float X, Y;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        Y += Input.GetAxis("Mouse Y") * sensitivity;

        transform.localEulerAngles = new Vector3(-Y, X, 0);
        transform.position = transform.localRotation * offset + player.transform.position;
    }
}
