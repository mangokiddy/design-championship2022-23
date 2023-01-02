using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramndom : MonoBehaviour
{
    
    public string run= "runboss";
    public string shoot = "bossshoot";
    public string die = "bossdie";
    public string currentstate;
    public string idle = "idle";
    public int health; 
    public GameObject bulletPrefab;
    public float bulletForce =  20f;
    
    
    Animator animator;
    public int delay;
    public int redelay;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0)
        {
            ChangeState(die);
        }
        delay-=1;
        if(health!=0||currentstate != die)
        {
            if(delay>0)
            {
                ChangeState(shoot);
                
            
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
            
                
            }
            else
            {
                ChangeState(idle);
            }
        }
        
        if(delay<=-redelay)delay=redelay;     
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
}
