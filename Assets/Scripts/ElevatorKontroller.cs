using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorKontroller : MonoBehaviour
{
    float dirY;
    [SerializeField, Range(0, 10)] private float speed = 2.0f;

    bool moveingUp = true;

    void Update()
    {
        if(transform.position.y > 4f) 
        {
            moveingUp = false;
        }

        if(transform.position.y < 0.03f) 
        {
            moveingUp = true;
        }

        if (moveingUp) 
        {
            transform.position = new Vector3(transform.position.x, 
                transform.position.y + speed * Time.deltaTime, transform.position.z);        
        }
        else 
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
    }
}
