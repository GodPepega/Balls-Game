using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject bolaVerde;

    float distance;
  

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        Collision(collision);
    }



    private void Collision(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            
            Debug.Log("a");

            bolaVerde.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-3f, 3f), 0);
          
            ScoreManager.instance.IncrementScore();
            
            
            int rand = Random.Range(0, 2);
            
            Vector3 spawnposition = new Vector3(Random.Range(-7f, 7f), Random.Range(-3f, 3f), 0);
            distance = Vector3.Distance(collision.transform.position, spawnposition);
            if (rand == 0)
            {
              
                BolasManager.instance.SpawnRed(distance, collision, spawnposition);
               
            }
            else
            {
               
                BolasManager.instance.SpawnFocar(distance, collision, spawnposition);
            }

          

        }
    }

    
}
