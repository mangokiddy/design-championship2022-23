using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTheBoxes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            //resetBoxes();
            Debug.Log("Reset The Boxes");
        }
    }

    private void resetBoxes()
    {
        /*GameObject.Find("YellowBox").transform.position = -3.9, -5.61, 0;
        GameObject.Find("GreenBox").transform.position = -3.55999994, 0.939999998, 0;
        GameObject.Find("RedBox").transform.position = -9.43999958, -5.9000001, 0;
        GameObject.Find("BlueBox").transform.position = -10.8999996,-2.19000006, 0;
        GameObject.Find("YellowBox(1)").transform.position = -7.88000011, 0.600000024, 0;
        GameObject.Find("GreenBox(1)").transform.position = -7.94999981, -2.30999994, 0;
        GameObject.Find("RedBox(1)").transform.position = -3.46000004, -1.61000001, 0;
        GameObject.Find("BlueBox(1)").transform.position = -6.03999996, -3.6099999, 0;*/
    }
}
