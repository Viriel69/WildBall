using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    float panelX;
    [SerializeField, Range(0, 10)] private float speedP = 2.0f;

    bool moveingSide = true;

    void Update()
    {
        if (transform.position.x > -12.5f)
        {
            moveingSide = false;
        }

        if (transform.position.x < -23.5f)
        {
            moveingSide = true;
        }

        if (moveingSide)
        {
            transform.position = new Vector3(transform.position.x + speedP * Time.deltaTime,
                transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speedP * Time.deltaTime,
                transform.position.y, transform.position.z);
        }
    }
}
