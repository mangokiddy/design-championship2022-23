using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckTheCode : MonoBehaviour
{
    public string TheCodeEntered;
    public GameObject inputField;
    public GameObject textDisplay;
    public string RealCode = "7194";

    private void Start()
    {
        textDisplay.SetActive(false);    
    }

    public void StoreTheCode()
    {
        TheCodeEntered = inputField.GetComponent<Text>().text;

        if(TheCodeEntered == RealCode)
        {
            GameObject.Find("NumberLock").SetActive(false);
            Destroy(GameObject.Find("CyberLock"), 0.01f);
        }

        else
        {
            textDisplay.SetActive(true);
        }
    }

}