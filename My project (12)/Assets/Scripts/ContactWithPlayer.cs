using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactWithPlayer : MonoBehaviour
{
    public bool playerHasKey;

    // Start is called before the first frame update
    void Start()
    {
        playerHasKey = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            playerHasKey = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            sfxManageAudio.sfxInstance.Audio.PlayOneShot(sfxManageAudio.sfxInstance.keyPickup);
        }
    }
}