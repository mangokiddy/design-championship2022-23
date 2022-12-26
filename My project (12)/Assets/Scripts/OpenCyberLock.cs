using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCyberLock : MonoBehaviour
{
    public GameObject NumLock;
    // Start is called before the first frame update
    void Start()
    {
        NumLock = GameObject.Find("NumberLock");
        NumLock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            NumLock.SetActive(true);
        }
           
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            NumLock.SetActive(false);
        }
    }
}
