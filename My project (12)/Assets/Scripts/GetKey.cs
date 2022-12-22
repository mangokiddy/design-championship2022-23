using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Key").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("KeyOnFloor").GetComponent<ContactWithPlayer>().playerHasKey = true)
        {
            GameObject.Find("Key").SetActive(true);
        }
    }
}
