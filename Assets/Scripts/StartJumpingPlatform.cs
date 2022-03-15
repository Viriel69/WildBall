using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartJumpingPlatform : MonoBehaviour
{
    private AudioSource springClip;

    private void Start()
    {
        springClip = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player") 
        {
            GetComponent<Rigidbody>().AddForce(0, 35, 0, ForceMode.Impulse);
        }
        springClip.Play();
    }
}
