using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject wicket;
    private AudioSource boomClip;

    private void Start()
    {
        boomClip = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(wicket);
        }
        boomClip.Play();
    }
}
