using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public bool invincibility = false;
    public Text loseLife;
    public GameObject gameOver;
    public static GMS liveScript;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        loseLife.text = "lives: " + GMS.lives.ToString();
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cactuses"))
        {
            if (!invincibility)
            {
                invincibility = true;
                GMS.lifeLoss(-1);
                Invoke("Inv", 2f);
            }
        }
    }
    void Inv()
    {
        invincibility = false;
    }
}
