using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    private PlayerController player;
   //rivate Vector2 movement;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (player.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    //public float checkRadius;
    //public float attackRadius;

    //public bool shoudRotate;

    /*public LayerMask Player;

    private Transform target;
    private Rigidbody2D rb;
    private Animation anim;
    private Vector2 movement;
    public Vector3 dir;

    //private bool isInChaseRange;
    //private bool isInAttackRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
        target = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    {
        //anim.SetBool("IsRunning", isInRange);

        dir = target.position - transform.position;
        float angle = Mathf.Atan(dir.y, dir.x) * Mathf.Rad2Deg;
        dir.Normalize();
        movement = dir;
    }
    private void MoveCharacter(Vector2 dir)
    {
        rb.MovePosition(Vector2)transform.position + (dir * speed * Time.deltaTime));
    }*/
}
