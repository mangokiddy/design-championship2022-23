using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            GameObject.Find("player").GetComponent<MovementPlayer>().currenthealth = 5;
            sfxManageAudio.sfxInstance.Audio.PlayOneShot(sfxManageAudio.sfxInstance.keyPickup);
            Destroy(GameObject.Find("heart"), 0.1f);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
