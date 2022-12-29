using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLock : MonoBehaviour
{
    public GameObject BoxSortText;
    public bool red;
    public bool yellow;
    public bool blue;
    public bool green;
    public bool allBoxes;


    // Start is called before the first frame update
    void Start()
    {
        allBoxes = false;
        BoxSortText.SetActive(false);
        red = GameObject.Find("RedBorder").GetComponent<RedBorder>().Red_Box_Entered;
        blue = GameObject.Find("BlueBorder").GetComponent<BlueBorder>().Blue_Box_Entered;
        green = GameObject.Find("GreenBorder").GetComponent<GreenBorder>().Green_Box_Entered;
        yellow = GameObject.Find("YellowBorder").GetComponent<YellowBorder>().Yellow_Box_Entered;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            BoxSortText.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            BoxSortText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        red = GameObject.Find("RedBorder").GetComponent<RedBorder>().Red_Box_Entered;
        blue = GameObject.Find("BlueBorder").GetComponent<BlueBorder>().Blue_Box_Entered;
        green = GameObject.Find("GreenBorder").GetComponent<GreenBorder>().Green_Box_Entered;
        yellow = GameObject.Find("YellowBorder").GetComponent<YellowBorder>().Yellow_Box_Entered;

        if(red == true && blue == true && green == true && yellow == true)
        {
            allBoxes = true;
        }

        if (allBoxes == true)
        {
            Debug.Log("Boxes are Sorted");
            BoxSortText.SetActive(false);
            Destroy(GameObject.Find("Color_Lock"), 0.03f);
        }
    }
}
