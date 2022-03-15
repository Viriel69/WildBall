using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    private Animator anim;
    private AudioSource collectingClip;
    private CoinsCounter coinsCounter;
    public GameObject PlayingField;
    public GameObject splashEffect;


    void Start()
    {
        anim = GetComponent<Animator>();
        collectingClip = GetComponent<AudioSource>();
        coinsCounter = PlayingField.GetComponent<CoinsCounter>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player") 
        {
            anim.SetTrigger("Collecting");
        }
        coinsCounter.Collecting();
        collectingClip.Play();
        splashEffect.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
