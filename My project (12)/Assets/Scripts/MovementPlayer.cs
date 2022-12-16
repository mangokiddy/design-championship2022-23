using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    bool FacingRight = true;

    // Start is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the horizontal movement from input system
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the vertical movement from input system
        float VerticalInput = Input.GetAxis("Vertical");

        //Move according to player Input
        body.velocity = new Vector2(horizontalInput * speed, VerticalInput * speed);

        //Flipping the player with right/left movement
        if(horizontalInput<0 && FacingRight)
        {
            flip();
        }

        else if (horizontalInput>0 && !FacingRight)
        {
            flip();
        }

    }

    void flip()
    {
        FacingRight = !FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
