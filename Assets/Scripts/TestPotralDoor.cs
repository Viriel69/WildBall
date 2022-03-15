using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPotralDoor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Player").transform.position = new Vector3(43, 5, 84);
    }
}
