using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTheBoxes : MonoBehaviour
{
    Vector3 yellowPos;
    Vector3 greenPos;
    Vector3 bluePos;
    Vector3 redPos;
    Vector3 yellowPos2;
    Vector3 greenPos2;
    Vector3 bluePos2;
    Vector3 redPos2;
    
    private void Start()
    {
        yellowPos = GameObject.Find("YellowBox").transform.position;
        greenPos = GameObject.Find("GreenBox").transform.position;
        redPos = GameObject.Find("RedBox").transform.position;
        bluePos = GameObject.Find("BlueBox").transform.position;
        yellowPos2 = GameObject.Find("YellowBox2").transform.position;
        greenPos2 = GameObject.Find("GreenBox2").transform.position;
        redPos2 = GameObject.Find("RedBox2").transform.position;
        bluePos2 = GameObject.Find("BlueBox2").transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            resetBoxes();
            Debug.Log("Reset The Boxes");
        }
    }

    private void resetBoxes()
    {
        GameObject.Find("YellowBox").transform.position = yellowPos;
        GameObject.Find("GreenBox").transform.position = greenPos;
        GameObject.Find("RedBox").transform.position = redPos;
        GameObject.Find("BlueBox").transform.position = bluePos;
        GameObject.Find("YellowBox2").transform.position = yellowPos2;
        GameObject.Find("GreenBox2").transform.position = greenPos2;
        GameObject.Find("RedBox2").transform.position = redPos2;
        GameObject.Find("BlueBox2").transform.position = bluePos2;
    }
}
