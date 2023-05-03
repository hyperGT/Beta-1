using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSaves : MonoBehaviour
{
    /**
     * O que estiver comentado ser� adicionado futuramente     
     * (pontua��o m�xima j� alcan�ada em uma partida)
     */

    private int finalScore;
    //private int highScore;
    public Text showFinalMatchScore;
    //public Text highestPlayerScore;

    private void Start()
    {
        finalScore = PlayerPrefs.GetInt("FinalScore");
        //highScore = PlayerPrefs.GetInt("MaxScore");
        Debug.Log(finalScore);
    }

    private void Update()
    {
        GameOverScoreCount();
    }

    void GameOverScoreCount()
    {
        showFinalMatchScore.text = finalScore.ToString("000");
        //highestPlayerScore.text = highScore.ToString("000");
    }

}
