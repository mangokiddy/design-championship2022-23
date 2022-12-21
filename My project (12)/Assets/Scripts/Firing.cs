using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int delay = 0;

    public float bulletForce =  20f;
    MovementPlayer player;
    

    // Update is called once per frame
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementPlayer>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            StartCoroutine(Shoot());
        }
        delay -= 1;
    }

    IEnumerator Shoot()
    {
        if(delay == 0||delay<=0)
        {
            player.ChangeState(player.shoot);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
            delay = 60;
            yield return new WaitForSeconds(0.22f);
            player.ChangeState(player.idle);
            
        }
        
        
    }
}
