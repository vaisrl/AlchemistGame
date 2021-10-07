using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    public Transform [] roads;
    public GameObject [] monsters;
    private float SpawnRate = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int random = Random.Range(0, 3);
        if (SpawnRate >= 5f)
        {
            
            Instantiate(monsters[random], roads[random].position, Quaternion.identity);
            SpawnRate = 0;
        }
        SpawnRate += Time.deltaTime;
    }
}
