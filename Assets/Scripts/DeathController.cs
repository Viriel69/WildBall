using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    [SerializeField] private GameObject overScreen;
    public GameObject player;
    public GameObject deathEffect;
    public float timer;
    public bool tActive = false;

    private void Update()
    {
        if (tActive) 
        {
            deathEffect.SetActive(true);
            overScreen.SetActive(true);
            timer -= Time.deltaTime;
            if(timer <= 0) 
            {
                player.SetActive(false);
                //Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player") 
        {
            tActive = true;
        }
    }
}
