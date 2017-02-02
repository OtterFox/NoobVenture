using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionAI : MonoBehaviour {

    public enum EnemyFaceDirection { Up = 0, Down = 1, Left = 2, Right = 3 }
    public EnemyFaceDirection enemyfDir;
    public AIWander wandering;

    //declare ranges to be called later for random movement
    public EnemyFaceDirection upTurn;
    public EnemyFaceDirection downTurn;
    public EnemyFaceDirection leftTurn;
    public EnemyFaceDirection rightTurn;

    void Start ()
    {
        enemyfDir = EnemyFaceDirection.Up;
               
        //set ranges to be called later for random movement
        upTurn = (EnemyFaceDirection)Random.Range(1, 3);     //down, left, right
        downTurn = (EnemyFaceDirection)Random.Range(2, 3);   //left, right
        leftTurn = (EnemyFaceDirection)Random.Range(0, 1);   //up, down
        rightTurn = (EnemyFaceDirection)Random.Range(0, 2);  //up, down, left
    }
	
	void Update ()
    {
        EnemyFaceDir();
    }

    public void EnemyFaceDir()
    {
        switch (enemyfDir)
        {
            case EnemyFaceDirection.Up:
                wandering.WalkUpAI();
                break;
            case EnemyFaceDirection.Down:
                wandering.WalkDownAI();
                break;
            case EnemyFaceDirection.Left:
                wandering.WalkLeftAI();
                break;
            case EnemyFaceDirection.Right:
                wandering.WalkRightAI();
                break;
        }
    }
}
