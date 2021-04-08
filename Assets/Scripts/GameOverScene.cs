using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    public Text highScoreText;
    private int score;
    
    void Start()
    {
        score = Score.valeurScore;
        highScoreText.text = "High Score : "  + PlayerPrefs.GetInt("HighScore", 0).ToString();
        SauvegarderScore();
    }

   void SauvegarderScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "High Score : " + score.ToString();
            SauvegarderFichier.Save(score);
        }
    }

    public void Rejouer()
    {
        SceneManager.LoadScene("Jeu");
    }
    
}
