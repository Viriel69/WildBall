using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public GameObject MainCamera;
    private Rigidbody rb;
    public float speed;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(Vector3.ProjectOnPlane(MainCamera.transform.forward, Vector3.up).normalized * 
                speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            rb.AddForce(Vector3.ProjectOnPlane(-MainCamera.transform.forward, Vector3.up).normalized *
                            speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(MainCamera.transform.right * speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-MainCamera.transform.right * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
