using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintController : MonoBehaviour
{
    public GameObject hintText;
    public float timer;
    public bool triggerActive = false;

    void Update()
    {
        if (triggerActive) 
        {
            hintText.SetActive(true);
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                hintText.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            triggerActive = true;
        }
    }
}
