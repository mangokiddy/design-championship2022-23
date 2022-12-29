using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDaBox : MonoBehaviour
{
    public bool Found_Green_Box;
    public bool Found_Blue_Box;
    public bool Found_Yellow_Box;
    public bool Found_Red_Box;
    private GameObject CurrentBox;
    
    // Start is called before the first frame update
    void Start()
    {
        Found_Blue_Box = false;
        Found_Green_Box = false;
        Found_Yellow_Box = false;
        Found_Red_Box = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RedBox")
        {
            Found_Blue_Box = false;
            Found_Green_Box = false;
            Found_Yellow_Box = false;
            Found_Red_Box = true;

            CurrentBox = other.gameObject;
            //CurrentBox.transform.position = other.gameObject.transform.position;
        }

        else if (other.gameObject.tag == "BlueBox")
        {
            Found_Blue_Box = true;
            Found_Green_Box = false;
            Found_Yellow_Box = false;
            Found_Red_Box = false;

            CurrentBox = other.gameObject;
            //CurrentBox.transform.position = other.gameObject.transform.position;
        }

        else if (other.gameObject.tag == "GreenBox")
        {
            Found_Blue_Box = false;
            Found_Green_Box = true;
            Found_Yellow_Box = false;
            Found_Red_Box = false;

            CurrentBox = other.gameObject;
            //CurrentBox.transform.position = other.gameObject.transform.position;
        }

        else if (other.gameObject.tag == "YellowBox")
        {
            Found_Blue_Box = false;
            Found_Green_Box = false;
            Found_Yellow_Box = true;
            Found_Red_Box = false;

            CurrentBox = other.gameObject;
            //CurrentBox.transform.position = other.gameObject.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CurrentBox.transform.position = GameObject.Find("boxHolder").transform.position;
    }
}
