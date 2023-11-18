using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolasManager : MonoBehaviour
{

    [SerializeField] GameObject bolaVermelha;
    [SerializeField] GameObject bolaFoco;
    GameObject bolaAdd;
    List<GameObject> Bolas = new List<GameObject>();

    public static BolasManager instance;
    bool cena2;
    void Start()
    {
        cena2 = TempoManager.instance.foiParaASegunda();
      
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

   
    public void SpawnFocar(float distance, Collider2D collision, Vector3 spawnposition)
    {
        if (!cena2)
        {
            
            while (distance < 2f)
            {
                spawnposition = new Vector3(Random.Range(-9f, -2f), Random.Range(2f, 3.8f), 0);
                distance = Vector3.Distance(collision.transform.position, spawnposition);
            }
        }
        else
        {


            while (distance < 2f)
            {
                spawnposition = new Vector3(Random.Range(-9f, 9f), Random.Range(2f, -2f), 0);
                distance = Vector3.Distance(collision.transform.position, spawnposition);
            }

        }
        bolaAdd = Instantiate(bolaFoco, spawnposition, Quaternion.identity);
        Bolas.Add(bolaAdd);
        
    }
    public void SpawnRed(float distance, Collider2D collision, Vector3 spawnposition)
    {
        if (!cena2)
        {
           
            while (distance < 2f)
            {
                spawnposition = new Vector3(Random.Range(-9f, -2f), Random.Range(2f, 3.8f), 0);
                distance = Vector3.Distance(collision.transform.position, spawnposition);
            }
        }
        else
        {


            while (distance < 2f)
            {
                spawnposition = new Vector3(Random.Range(-9f, 9f), Random.Range(2f, -2f), 0);
                distance = Vector3.Distance(collision.transform.position, spawnposition);
            }

        }

        bolaAdd = Instantiate(bolaVermelha, spawnposition, Quaternion.identity);
        Bolas.Add(bolaAdd);
        
    }



    public void DestroyList()
    {
        foreach(GameObject obj in Bolas)
        {
            Destroy(obj);
        }
    }
}
