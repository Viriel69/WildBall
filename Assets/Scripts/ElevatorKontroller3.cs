using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorKontroller3 : MonoBehaviour
{
    float dirY1;
    [SerializeField, Range(0, 10)] private float speed = 2.0f;

    bool moveing = true;

    void Update()
    {
        if(transform.position.y > 4.44f) 
        {
            moveing = false;
        }

        if(transform.position.y < 0.95f) 
        {
            moveing = true;
        }

        if (moveing) 
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
