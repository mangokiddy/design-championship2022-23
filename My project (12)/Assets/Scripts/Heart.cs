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
            Destroy(GameObject.Find("heart"), 0.10f);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
