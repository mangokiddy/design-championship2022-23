using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBorder : MonoBehaviour
{
    private bool Box1entered;
    private bool Box2entered;
    public bool Green_Box_Entered;

    // Start is called before the first frame update
    void Start()
    {
        Box1entered = false;
        Box2entered = false;
        Green_Box_Entered = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "GreenBox")
        {
            Box1entered = true;
        }
        if (other.gameObject.name == "GreenBox2")
        {
            Box2entered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "GreenBox")
        {
            Box1entered = false;
        }
        if (other.gameObject.name == "GreenBox2")
        {
            Box2entered = false;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (Box1entered == true && Box2entered == true)
        {
            Green_Box_Entered = true;
        }
        else 
        {
            Green_Box_Entered = false;
        }
    }
}
