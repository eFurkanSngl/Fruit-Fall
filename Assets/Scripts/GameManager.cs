using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
   
    //[SerializeField] private BoxCollider2D col;
    [SerializeField] private GameObject[] gameObjects;
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPrefab());
      
      
    }
    IEnumerator SpawnPrefab()
    {
        while (true)
        {
            
           
            for(int i = 0; i < 4; i++) // 5 tane Prefab ��kmas�n� istiyoruz
            {
                int randomIndex = Random.Range(0, gameObjects.Length); // Random 0 ile liste uzunlu�u aras�nda bir de�er als�n
                GameObject prefab = gameObjects[randomIndex]; // D�nen de�erleri prefbe at�yoruz

                Vector2 pos = new Vector2(Random.Range(-8,8),5f); // yarataca�� konum

                GameObject Instan = Instantiate(prefab, pos, Quaternion.identity);// Yaratma methodu
                
                
            }

            yield return new WaitForSeconds(1f);// 2sn bekledik tekrar ettik
           
                //Bounds bounds = col.bounds;  // Collider �Le bir s�n�r belirledik
                //float x = Random.Range(bounds.min.x, bounds.max.x);
                //float y = Random.Range(bounds.min.y, bounds.max.y);
        }
    }

    


    


}

