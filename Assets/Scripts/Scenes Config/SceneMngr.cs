using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMngr : MonoBehaviour
{
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);   
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Saindo do jogo");
    }
}
