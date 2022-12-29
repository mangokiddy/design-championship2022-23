using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLock : MonoBehaviour
{
    public bool touchingPlayer;
    public GameObject SortBoxText;
    
    // Start is called before the first frame update
    void Start()
    {
        touchingPlayer = false;
        SortBoxText.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            touchingPlayer = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            touchingPlayer = false;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        if (touchingPlayer == true)
        {
            SortBoxText.SetActive(true);
        }
        else 
        {
            SortBoxText.SetActive(false);
        }
    }
}
