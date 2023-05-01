using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Header("Player Life")]
    [SerializeField] private int life;

    void Start() => life = 2;
    

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            SceneManager.LoadScene("Game Over");
            Debug.Log("Morreu");
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
