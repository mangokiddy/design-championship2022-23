using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            Destroy(this.gameObject, 0.01f);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
