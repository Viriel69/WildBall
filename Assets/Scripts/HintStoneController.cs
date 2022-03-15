using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintStoneController : MonoBehaviour
{
    public GameObject hintText;
    public float timer;
    public bool collisionActive = false;

    void Update()
    {
        if (collisionActive)
        {
            hintText.SetActive(true);
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                hintText.SetActive(false);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collisionActive = true;
        }
    }
}
