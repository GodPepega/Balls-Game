using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaFocar : BolaVerde
{
    GameObject player;
    
    float bounceForce = 2.5f;
    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    

    public override void Bounce(Collision2D collision, Vector3 lastVel)
    {
        
        Vector2 direcao = (player.transform.position - transform.position).normalized;


        rb.velocity = direcao * bounceForce;

        if (gameObject.tag == "BolaVermelha" && collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<Movement>().getHurt();
            TempoManager.instance.ResetTime();

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Bounce(collision, lastVel);
    }


}
