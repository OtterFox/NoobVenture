using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour {

    public GameObject enemy;
    public GameObject enemyPrefab;
    [SerializeField] int enemyCount = 4;
    // Use this for initialization

    private void Awake()
    {
        EnemySpawn();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void EnemySpawn() //make sure to spawn enemes and add them to list once done.
    {
        
        for (int i = 0; i <= enemyCount; i++)
        {
            int spawnX = Random.Range(-11, 12);
            int spawnY = Random.Range(2, 7);
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(spawnX, spawnY, -.05f), transform.rotation);
           
            print("Enemy Number" + i);
        }
    }
}
