using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBorder : MonoBehaviour
{
    private bool Box1entered;
    private bool Box2entered;
    public bool Blue_Box_Entered;

    // Start is called before the first frame update
    void Start()
    {
        Box1entered = false;
        Box2entered = false;
        Blue_Box_Entered = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "BlueBox")
        {
            Box1entered = true;
        }
        if (other.gameObject.name == "BlueBox2")
        {
            Box2entered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "BlueBox")
        {
            Box1entered = false;
        }
        if (other.gameObject.name == "BlueBox2")
        {
            Box2entered = false;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (Box1entered == true && Box2entered == true)
        {
            Blue_Box_Entered = true;
        }
        else 
        {
            Blue_Box_Entered = false;
        }
    }
        
}