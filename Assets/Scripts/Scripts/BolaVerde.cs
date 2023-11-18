using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaVerde : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody2D rb;
    protected Vector3 lastVel;
    
   
    private void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(90.8f, 90.8f, 0f));

    }
    private void Update()
    {
        lastVel = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce(collision, lastVel);
    }

    public virtual void Bounce(Collision2D collision, Vector3 latVel)
    {
        
        var speed = lastVel.magnitude;
        var direction = Vector3.Reflect(lastVel.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
        
    }
}

