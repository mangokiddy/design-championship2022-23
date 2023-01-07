using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSource : MonoBehaviour
{
    public float currentPower;
    public bool powerDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        currentPower = 5f;
        powerDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentPower);
        
        if (currentPower <= 0f)
        {
            powerDestroyed = true;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(GameObject.Find("lightning-131982518827228370"));
        }
    }
}
