using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public bool canBeTransfered;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canBeTransfered = true;
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);    
        if (rb.velocity.x > 0)
            canBeTransfered = false;
    }
    
}
