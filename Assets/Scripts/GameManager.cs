using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    [SerializeField] private GameObject prefab;
    [SerializeField] private BoxCollider2D col;
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnPrefab()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, gameObjects.Count);
            prefab = gameObjects[randomIndex];
            // listeyi Random olarak ald�k

            Bounds bounds = col.bounds;
            //float x = Random.Range(bounds.min.x, bounds.max.x);
           //float y = Random.Range(bounds.min.y, bounds.max.y);
            // Collider �Le bir s�n�r belirledik

            Vector2 pos = new Vector2(Random.Range(-8,8),3f);
            // Tam de�er yuvaralad�k


            GameObject Instan = Instantiate(prefab, pos, Quaternion.identity);
            // Obje yaratt�k

            
            


            yield return new WaitForSeconds(4f);
            // 2sn bekledik tekrar ettik
        }
    }

}

