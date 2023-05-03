using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCont : MonoBehaviour
{
    public Text scoreText;    
    //public static int finalMatchScore;
    //public static int maxScore;
    public static int matchScore;

    
    /** verificar/testar : 
     * 1 - Sistema de pontuação tem que estar funcionando(na tela de jogo)
     * 
     * 2 - No script "Life" do jogador, 
     * a pontuação da partida deve estar sendo salva corretamente.
     * 
     * 3 - O script ScoreSaves tem que estar funcionando da seguinte maneira:
     * ao entrar na cena "Game Over" o valor de Score deve ser o valor salvo na variavel.
     * 
     * resultado 3/3 (tudo funcionando crlhouuuuu)
     */
    
    void Start()
    {
        //matchScore = PlayerPrefs.GetInt("MatchScore");
        //Debug.Log(PlayerPrefs.GetInt("MatchScore"));
    }

    
    void Update()
    {
        UpdatedScore();                
    }

    

    void UpdatedScore()
    {        
        scoreText.text = matchScore.ToString("000");

        //finalMatchScore = matchScore;

        //Debug.Log(finalMatchScore);
        //PlayerPrefs.SetInt("MatchScore", finalMatchScore);
        //PlayerPrefs.SetInt("MaxScore", maxScore);
    }
}
