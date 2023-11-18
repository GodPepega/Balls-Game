using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    int score;
    int highscore = 0;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

   
    void Update()
    {
        
    }

    public int GetHighScore()
    {
        return highscore;
    }

    public int GetScore()
    { 
        return score;
    }

    public void IncrementScore()
    {
     
        score++;
        if(score >= highscore)
        {
            highscore = score;
        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
