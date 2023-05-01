using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCont : MonoBehaviour
{
    public Text scoreText;    
    public static int score;
    public static int maxScore;

    
    
          

    void Start()
    {        
        maxScore = PlayerPrefs.GetInt("score");
        Debug.Log(PlayerPrefs.GetInt("score"));
    }

    
    void Update()
    {
        UpdatedScore();                
    }

    

    void UpdatedScore()
    {        
        scoreText.text = score.ToString("000");
        
        PlayerPrefs.SetInt("score", maxScore);
    }
}
