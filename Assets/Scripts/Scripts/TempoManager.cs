using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempoManager : MonoBehaviour
{
    float tempo;
    bool cena1 = true;
    bool cena2 = true;
    bool contarTempo = true;

    public static TempoManager instance;

    private void Awake()
    {
        contarTempo = true;
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);
        tempo = 0f;
    }
   

    void Update()
    {
        Debug.Log(Mathf.Round(tempo));
        if(contarTempo)
        {
            tempo += Time.deltaTime;
        }
        

        if(tempo > 30 && cena1 && cena2)
        {
            cena1 = false;
            SceneManager.LoadScene("SecondScene");
            


        }
        if(tempo > 60 && cena2)
        {
            BolasManager.instance.DestroyList();
            cena2 = false;
            Destroy(FindObjectOfType<Movement>());

            SceneManager.LoadScene("EndGameScene");
            ResetTime();
            
        }
    }

    public void ResetTime()
    {
        contarTempo = false;
        tempo = 0;
    }

    public void PlayTime()
    {
        contarTempo = true;
        tempo = 0;
    }   

    public bool foiParaASegunda()
    {
        if(!cena1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    
}
