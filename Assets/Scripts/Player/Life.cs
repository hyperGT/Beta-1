using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Header("Player Life")]
    [SerializeField] private int life;
    private int finalMatchScore;

    void Start() => life = 2;
    

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene("Game Over");
            finalMatchScore = ScoreCont.matchScore;
            Debug.Log(ScoreCont.matchScore);
            Debug.Log(finalMatchScore);
            Debug.Log("Morreu");
            ScoreCont.matchScore = 0;
            PlayerPrefs.SetInt("FinalScore", finalMatchScore);
            Debug.Log(ScoreCont.matchScore);
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Enemy_Projectile")
        {
            life--;
        }
    }
}
