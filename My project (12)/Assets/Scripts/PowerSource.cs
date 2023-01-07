using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSource : MonoBehaviour
{
    public float currentPower;

    // Start is called before the first frame update
    void Start()
    {
        currentPower = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentPower);
        
        if (currentPower <= 0f)
        {
            Debug.Log("YOU WIN!!!!!");
        }
    }
}
