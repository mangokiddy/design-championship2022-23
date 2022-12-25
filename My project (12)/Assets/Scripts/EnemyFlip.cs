using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{
    public Transform enemy;
    SpriteRenderer sprite;
    
    public Transform player;
    void Awake()
    {
        sprite = this.GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        if(player.position.x < enemy.position.x)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
}
