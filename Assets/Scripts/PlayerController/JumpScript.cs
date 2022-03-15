using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public bool isGrounded;
    public int jumpForce;

    public void Jump() 
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if(Physics.Raycast(ray, out rh, 0.45f)) 
        {
            isGrounded = true;
        }
        else 
        {
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
    void Update()
    {
        Jump();
    }
}
