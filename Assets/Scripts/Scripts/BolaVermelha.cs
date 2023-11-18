using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaVermelha : BolaVerde
{
    

    public override void Bounce(Collision2D collision, Vector3 lastVel)
    {
        
        if (gameObject.tag == "BolaVermelha" && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Movement>().getHurt();
            collision.gameObject.SetActive(false);
            TempoManager.instance.ResetTime();
            ManagerScene.instance.Scne2();

        }
        else
        {
            base.Bounce(collision, lastVel);
        }

        
    }
}
