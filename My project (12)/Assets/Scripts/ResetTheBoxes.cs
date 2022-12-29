using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTheBoxes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            //resetBoxes();
            Debug.Log("Reset The Boxes");
        }
    }

    private void resetBoxes()
    {
        GameObject.Find("YellowBox").transform.position = new Vector3(-3.9f, -5.61f, 0f);
        GameObject.Find("GreenBox").transform.position = new Vector3(-3.55999994f, 0.939999998f, 0f);
        GameObject.Find("RedBox").transform.position = new Vector3(-9.43999958f, -5.9000001f, 0f);
        GameObject.Find("BlueBox").transform.position = new Vector3(-10.8999996f,-2.19000006f, 0f);
        GameObject.Find("YellowBox(1)").transform.position = new Vector3(-7.88000011f, 0.600000024f, 0f);
        GameObject.Find("GreenBox(1)").transform.position = new Vector3(-7.94999981f, -2.30999994f, 0f);
        GameObject.Find("RedBox(1)").transform.position = new Vector3(-3.46000004f, -1.61000001f, 0f);
        GameObject.Find("BlueBox(1)").transform.position = new Vector3(-6.03999996f, -3.6099999f, 0f);
    }
}
