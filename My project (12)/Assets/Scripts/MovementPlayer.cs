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
    
    
    
    [SerializeField]string currentstate;

    // Start is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the horizontal movement from input system
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the vertical movement from input system
        float VerticalInput = Input.GetAxis("Vertical");
        

        //Move according to player Input
        if(currentstate == shoot)
        {
            body.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            body.velocity = new Vector2(horizontalInput * speed, VerticalInput * speed);
            body.constraints = RigidbodyConstraints2D.None;
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
            if(currentstate != shoot)
            {
                ChangeState(run);
            }
        }
        else if(VerticalInput!=0)
        {
            if(currentstate != shoot)
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

            if(currentstate != "fire")
            {
                ChangeState(idle);
            }
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
}
