using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager gMan = null;
    public GameObject enemy;
    public GameObject player;
    public GameObject bullet;
    public GameObject bulletPrefab;
    public ProjectileMove pMove;
    public MoveDirection mDir;
    public AIWander wander;
    public SpawnAI spawnE;
    public Projectiles proj;


    void Awake()
    {
     
      if(gMan == null)
        {
            gMan = this;
        }
        else if (gMan != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

       
    }

    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    //will need to eventually move to AIWander or AISpawn
    
    
}
