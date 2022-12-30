using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class homing : MonoBehaviour
{
    public Transform target;
    private Rigidbody2D rb;
    public float speed = 7;
    public float rotateSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();
        float rotate = Vector3.Cross(direction,transform.up).z;
        rb.angularVelocity = -rotate*rotateSpeed;
        rb.velocity = transform.up*speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
