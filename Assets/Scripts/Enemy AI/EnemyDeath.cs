using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private int enemyLife;
    [SerializeField] private int enemyDeathsCont = 0;
    public Text scoreText;

    void Start()
    {          
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyLife <= 0) { 
            Destroy(gameObject);
            enemyDeathsCont+=10;
        }
        scoreText.text = enemyDeathsCont.ToString("000");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            enemyLife--;
        }
    }


}
