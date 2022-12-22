using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public string idle= "Idle_enemy";
    public string run= "run";
    public string shoot = "attack";
    public string die = "Enemy_die";
    Animator animator;
    Collider2D collider;
    
    [SerializeField]string currentstate;
    private void Awake()
    {
        collider = GetComponent<Collider2D>();
        
        animator = GetComponent<Animator>();
    }
    

    void Update()
    {
        if(health <= 0)
        {
            ChangeState(die);
            collider.enabled = false;
            /*if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Enemy_die"))
            {
                Destroy(gameObject);
            }*/
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Bullet")
        {
            health -= 1;
        }
    }
    public void ChangeState(string newstate)
    {
        if(currentstate == newstate)return;
        animator.Play(newstate);
        currentstate = newstate;
    }

}