using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private GameObject overScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player") 
        {
            Time.timeScale = 0;
            overScreen.SetActive(true);
        }
    }
}
