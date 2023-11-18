using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rgd;
   
    float velocidade = 5f;
    float horizontal;
    float vertical;


   
    public Animator animadormeu;
    public Animator animador;
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
       
        rgd = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal") * velocidade;
        animadormeu.SetFloat("Speed", Mathf.Abs(horizontal));
        vertical = Input.GetAxisRaw("Vertical") * velocidade;
        animador.SetFloat("Speed", Mathf.Abs(vertical));

    }
    private void FixedUpdate()
    {
        
        
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(velocidade * horizontal, velocidade * vertical, 0);

            rgd.velocity = movement;


        
            
        
        
    }


    public void getHurt()
    {
        rgd.bodyType = RigidbodyType2D.Static;
        if (gameObject.CompareTag("BolaVermelha"))
        {
            Destroy(gameObject);
        }

    }

    public void Morte()
    {
        Destroy(gameObject);
        BolasManager.instance.DestroyList();
        SceneManager.LoadScene("EndGameScene");
        TempoManager.instance.ResetTime();
        Destroy(gameObject);
       
    }
}
