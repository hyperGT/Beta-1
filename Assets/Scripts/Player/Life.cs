using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Header("Player Life")]
    [SerializeField] private int life;
    public SpriteRenderer playerSpriteColor;
    private int finalMatchScore;

    void Start()
    {                
        playerSpriteColor = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene("Game Over");
            finalMatchScore = ScoreCont.matchScore;            
            Debug.Log("Morreu");
            ScoreCont.matchScore = 0;
            PlayerPrefs.SetInt("FinalScore", finalMatchScore);            
        }

        cheatDeVida();

    }

    void cheatDeVida()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            life += 3;
        }
    }


    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Enemy_Projectile")
        {
            life--;

            //change the color based in player current life
            if (life >= 3)
            {
                playerSpriteColor.color = new Color(1f, 1f, 1f, 1f); //yellow
            }
            else if(life == 2)
            {
                playerSpriteColor.color = new Color(1f, 0.5f, 0f, 1f); //orange
            }
            else 
            {
                playerSpriteColor.color = new Color(1f, 0f, 0f, 1f);
            }
        }
    }
}
