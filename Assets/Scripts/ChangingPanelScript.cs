using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingPanelScript : MonoBehaviour
{
    public Rigidbody rig;
    public float mass;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rig.mass = mass;
        }
    }

}
