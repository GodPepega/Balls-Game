using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{


    public TextMeshProUGUI messageText;
   
    static public Contador contador;
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        contador = this;
    }

    void Update()
    {
        
        if(gameObject.tag == "ScoreFinal")
        {
            messageText.SetText("SCORE: " + ScoreManager.instance.GetScore() + "\n\n\nHIGHSCORE: " + ScoreManager.instance.GetHighScore());
        }
        else
        {
            messageText.SetText($"SCORE: {ScoreManager.instance.GetScore()}");
        }


            
           

        
    }

    public void HighScore()
    {
        messageText.SetText("SCORE: " +  ScoreManager.instance.GetScore() + "\nHIGHSCORE: " + ScoreManager.instance.GetHighScore());

    }

    public void destroyMydaddy()
    {
        Destroy(gameObject);
    }
   

}
