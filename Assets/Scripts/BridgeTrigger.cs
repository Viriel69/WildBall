using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    public GameObject sBridge;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") 
        {
            sBridge.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            sBridge.SetActive(false);
        }
    }
}
