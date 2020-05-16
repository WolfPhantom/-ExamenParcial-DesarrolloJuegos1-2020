using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    [Header("HUD")]
    public Text txtScore;
    public Text txtVidas;
    public float score = 0f;
    public float vidas = 5;


    public string getScore()
    {
        return score.ToString();
    }
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "puntaje: " +score.ToString();
        txtVidas.text = "vidas: " + vidas.ToString();
        if (vidas == 0) 
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
