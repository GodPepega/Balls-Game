using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    private float elapsedTime = 0f;
    public float timeToChangeScene = 30f;


    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= timeToChangeScene)
        {
            //SceneManager.LoadScene("SecondScene");
        }

    }
}
