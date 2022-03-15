using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Цель
    public Transform target;

    //Скорость слежения
    public float speed = 4f;

    //Маска слоев препятствий
    public LayerMask maskObstacles;

    private Vector3 _position;

    void Start()
    {
        _position = target.InverseTransformPoint(transform.position);
    }

    void Update()
    {
        var currentPosition = target.TransformPoint(_position);
        transform.position = Vector3.Lerp(transform.position, currentPosition, speed * Time.deltaTime);
        var currentRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, speed * Time.deltaTime);

        RaycastHit hit;
        if (Physics.Raycast(target.position, transform.position - target.position, out hit, Vector3.Distance(transform.position, target.position), maskObstacles))
        {
            transform.position = hit.point;
            transform.LookAt(target);
        }
    }
}
