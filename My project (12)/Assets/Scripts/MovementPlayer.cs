using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    bool FacingRight = true;
    Animator animator;
    public string idle= "idle";
    public string run= "run";
    public string shoot = "fire";
    public string hit = "Hit";
    public string die = "die";
    Enemy enemy;
    SpriteRenderer R;
    public int hitdel;
    public bool isRunning;

    public int currenthealth = 5;
    public int maxhealth = 5;
    public bool GameEnded;
    
    
    
    
    public string currentstate;   

    // Start is called before the first frame update
    private void Awake()
    {
        isRunning = false;
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currenthealth = maxhealth;
        R = GetComponent<SpriteRenderer>();
        GameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        hitdel-=1;
        //Get the horizontal movement from input system
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the vertical movement from input system
        float VerticalInput = Input.GetAxis("Vertical");
        

        //Move according to player Input
        if(currentstate == shoot||hitdel >0||currentstate == die)
        {
            body.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            body.velocity = new Vector2(horizontalInput * speed, VerticalInput * speed);
            body.constraints = RigidbodyConstraints2D.None;
            body.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if(body.constraints == RigidbodyConstraints2D.None)
        {
            body.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        
        //Flipping the player with right/left movement
        if(horizontalInput<0 && FacingRight)
        {
            flip();
        }

        else if (horizontalInput>0 && !FacingRight)
        {
            flip();
        }

        //animation
        if(horizontalInput != 0)
        {
            if(currentstate != shoot&&currentstate!=die)
            {
                ChangeState(run);
            }
        }
        else if(VerticalInput!=0)
        {
            if(currentstate != shoot&&currentstate!=die)
            {
                ChangeState(run);
            }
        }
        
        else
        {
            /*if(Input.GetKeyDown(KeyCode.Space))
            {
                ChangeState(shoot);
            }*/

            if(currentstate != shoot&&currentstate!=die)
            {
                ChangeState(idle);
            }
        }
        if(currenthealth<=0)
        {
            ChangeState(die);
        }
        if(hitdel<=0)
        {
            R.color = Color.white;
        }

        if (currenthealth <= 0)
        {
            GameEnded = true;
        }
        else
        {
            GameEnded = false;
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            damage(1);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            ChangeState(run);
            
        }
    }

    void flip()
    {
        FacingRight = !FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    public void ChangeState(string newstate)
    {
        if(currentstate == newstate)return;
        animator.Play(newstate);
        currentstate = newstate;
    }
    public void damage(int amount)
    {
        hitdel = 49;
        R.color = Color.red;
        currenthealth-=amount;
        
    }
}
