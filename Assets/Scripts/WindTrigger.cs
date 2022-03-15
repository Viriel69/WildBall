using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTrigger : MonoBehaviour
{
    public bool windA = false;
    public Rigidbody windActive;

    void Update()
    {
        if (windA)
        {
            windActive.AddForce(0, 2, 0, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player") 
        {
            windA = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            windA = false;
        }
    }
}
