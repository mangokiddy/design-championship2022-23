using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDaDoor : MonoBehaviour
{
    public GameObject FindTheKeyText;

    // Start is called before the first frame update
    void Start()
    {
        FindTheKeyText = GameObject.Find("FindKeyText");
        FindTheKeyText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Key")
        {
            FindTheKeyText.SetActive(false);
            sfxManageAudio.sfxInstance.Audio.PlayOneShot(sfxManageAudio.sfxInstance.lockOpened);
            //Debug.Log("Door Opened");
            Destroy(gameObject, 0.01f);
            Destroy(GameObject.Find("Key"));
        }    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            FindTheKeyText.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            FindTheKeyText.SetActive(false);
        }
    }
}
