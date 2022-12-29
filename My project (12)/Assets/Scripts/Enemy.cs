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
    Rigidbody2D r;
    SpriteRenderer sprite;
    public int delay = 200;
    public int redelay = 200;
    public int idledur = -350;
    //AIDestinationSetter setter;
    //AIPath path;
    //Seeker seek;
    public string currentstate;
   
    void Start()
    {
        
    }
    
    
    private void Awake()
    {
        r = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
        //setter = GetComponent<AIDestinationSetter>();
       // path = GetComponent<AIPath>();
        //seek = GetComponent<Seeker>();
        
        animator = GetComponent<Animator>();
    }
    

    void Update()
    {
        delay -=1;
        if(health <= 0)
        {
            ChangeState(die);
            collider.enabled = false;
            r.constraints = RigidbodyConstraints2D.FreezeAll;
           /*path.enabled = false;
            seek.enabled = false;
            setter.enabled = false;
            /*if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Enemy_die"))
            {
                Destroy(gameObject);
            }*/
            
        }
        
        if(health>0)
        {
            if(r.IsSleeping())
            {
                if(delay>0)
                {
                    ChangeState(shoot);
                }
                else
                {
                    ChangeState(idle);
                }
                

            }
            else
            {
                
                
                ChangeState(run);
                
            
            
            } 
        }
        if(delay < idledur)
        {
            delay = redelay;
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
        if(currentstate!=newstate)
        {
            animator.Play(newstate,0);
        }
    }
    IEnumerator attack()
    {
        
        yield return new WaitForSeconds(1);
        
        
    }

}