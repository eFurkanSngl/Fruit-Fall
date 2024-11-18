using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDetected : MonoBehaviour
{
    private ScoreManager _scoreManager;

    private void Start()
    {
        _scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vehicle"))
        {
            Destroy(gameObject);
            _scoreManager.GameOver();
        }
    }

}
