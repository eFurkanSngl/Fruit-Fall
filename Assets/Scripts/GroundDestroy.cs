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
    }

    private void OnMouseDown()  // MouseDown Obje de bir Collider var ise �al���r ve kameran�n g�rebildi�i bir yerde olmas� gerekir.
    {
        if (gameObject.CompareTag("Bait"))
        {
            Destroy(gameObject);
            scoreManager.IncrementScore(10);
        }
    }
}
