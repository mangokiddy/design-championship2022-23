using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxManageAudio : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip shoot;
    public AudioClip lockOpened;
    public AudioClip deadEnemy;
    public AudioClip keyPickup;
    //public AudioClip running;
    public static sfxManageAudio sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
