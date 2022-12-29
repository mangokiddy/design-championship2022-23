using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart5 : MonoBehaviour
{
    MovementPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<MovementPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.currenthealth == 5)
        {
            
        }
        else
        {
        }
            
    }
}
