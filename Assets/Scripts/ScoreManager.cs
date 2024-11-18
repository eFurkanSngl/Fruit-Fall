using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
   private int _score;

    // Start is called before the first frame update
    void Start()
    {
     
        _score = 0;
        
    }

    public void IncrementScore(int score )
    {
       _score += score;
        UpdateScore();
    }

   public void UpdateScore()
    {
        if(scoreText != null)
        {
            scoreText.text = "Score:"  + _score.ToString();
        }
    }


    public void GameOver()
    {
        Time.timeScale = 0;
        Debug.Log("Game Over");
    }
}
