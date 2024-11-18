using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
  ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("Vehicle"))
        {
            scoreManager.IncrementScore(15);
            Destroy(gameObject);
        }
    }

   

}
