using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private int enemyLife;
    private int savePoints = 0;        
    [SerializeField] private int enemyPointsValue = 0;
    

    

    void Start()
    {               
        
    }

    // Update is called once per frame
    void Update()
    {
        Score();
       
    }

    public void Score()
    {
        if (enemyLife <= 0)
        {
           Destroy(gameObject); 
           savePoints += enemyPointsValue;
            //Debug.Log(savePoints);
            ScoreCont.score += savePoints;
            ScoreCont.maxScore += savePoints;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            enemyLife--;
        }
    }


}
