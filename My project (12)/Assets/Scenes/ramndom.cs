using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramndom : MonoBehaviour
{
    
    public string run= "runboss";
    public string shoot = "bossshoot";
    public string die = "bossdie";
    public string currentstate;
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float MaxDist;
    Vector2 wayPoint;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,wayPoint,speed*Time.deltaTime);
        if(Vector2.Distance(transform.position,wayPoint)<range)
        {
            ChangeState(shoot);
            
            SetNewDestination();
        }
        else
        {
            ChangeState(run);
        }
        
        
    }
    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-MaxDist,MaxDist),Random.Range(-MaxDist,MaxDist));
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
