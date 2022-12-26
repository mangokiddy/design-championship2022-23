using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject Key_On_The_Head;
    public GameObject KeyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("KeyOnFloor").GetComponent<ContactWithPlayer>().playerHasKey == true)
        {
            
            if(Key_On_The_Head != null)              // Checking if the Key gameobject still exists
            {
                Key_On_The_Head.SetActive(true);
                //Debug.Log("In Contact");
            }
            
        }

        if(GameObject.Find("Door") == null)
        {
            KeyText.SetActive(false);
        }

    }
}
