using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{

    static public ManagerScene instance;
    private void Start()
    {
        instance = this;
    }

    void Update()
    {
     
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "EndGameScene")
        {
            Contador.contador.destroyMydaddy();

            DestroyGameObjectsWithTag("Player");
            DestroyGameObjectsWithTag("BolaVerde");
            DestroyGameObjectsWithTag("BolaVermelha");
            
        }

      

        if (scene.name == "MainMenu")
        {
            Contador.contador.destroyMydaddy();
            DestroyGameObjectsWithTag("ScoreFinal");
            DestroyGameObjectsWithTag("ScoreInGame");
            DestroyGameObjectsWithTag("BolaVerde");
            DestroyGameObjectsWithTag("BolaVermelha");
        }
    }

    void DestroyGameObjectsWithTag(string tag)
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in gameObjects)
        {
            Destroy(obj);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }




public void StartGame()
    {
        
        if(ScoreManager.instance != null)
        {
            TempoManager.instance.PlayTime();
            ScoreManager.instance.ResetScore();
        }

        SceneManager.LoadScene("SampleScene");
        Contador.contador.destroyMydaddy();
        DestroyGameObjectsWithTag("ScoreFinal");

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Scne2()
    {
        SceneManager.LoadScene("EndGameScene");
    }
    

}
