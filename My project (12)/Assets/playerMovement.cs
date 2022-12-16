using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        body.velocity = new Vector2(horizontalInput * speed, VerticalInput * speed);

        //body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        //body.velocity = new Vector2(body.velocity.y, VerticalInput * speed);
    }
}
