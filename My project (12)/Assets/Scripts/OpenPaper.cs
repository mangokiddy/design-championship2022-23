using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPaper : MonoBehaviour
{
    private GameObject ThePaper;

    private void Start()
    {
        ThePaper = GameObject.Find("Paper_1");
        ThePaper.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
           ThePaper.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
           ThePaper.SetActive(false);
        }
    }
}