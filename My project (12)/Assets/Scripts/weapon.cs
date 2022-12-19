using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 40;
    public int delay = 500;
    public LineRenderer line;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
        delay -= 1;
    }
    IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position,firePoint.right);
        if(delay == 0||delay<=0)
        {
            if(hitInfo)
            {
                Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
                if(enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
                line.SetPosition(0, firePoint.position);
                line.SetPosition(1, hitInfo.point);
            }
            else
            {
                line.SetPosition(0, firePoint.position);
                line.SetPosition(1, firePoint.position + firePoint.right*100);
            }
        
            line.enabled = true;
            yield return new WaitForSeconds(0.02f);
            line.enabled = false;
            delay = 240;
        }
        
        
    }
}
