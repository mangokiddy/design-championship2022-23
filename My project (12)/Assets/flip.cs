using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public Transform enemy;
    
    
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.x < enemy.position.x)
        {
            enemy.position =new Vector3(-0.870000005f,-0.589999974f,0.00429558754f);
        }
        else
        {
            enemy.position =new Vector3(0.850000024f,-0.589999974f,0.00429558754f);
        }
    }
}
