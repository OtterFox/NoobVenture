using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWander : MonoBehaviour {
   
    //Eventually add sphere cast to detect player. 
    [SerializeField] GameObject _brokenCube;        //sets out broken cube object
    [SerializeField] MoveCntrller mCntrl;
    [SerializeField] DirectionAI dirAI;
    float turnTime;                                 //time for object to wait until auto turning to simulate AI

    void Start ()
    {
       mCntrl._speed = Random.Range(2,5);         //Sets speed of AI   
       turnTime = Random.Range(2, 5);
    }
	
	void Update ()
    {
       // print(turnTime);
       //AI should always be moving
        TurnTimeTracker();                           //AI Should always track its turn timer.
       //print("Enemy Dir = " + GameManager.gMan.mDir.fDir);        //Send what dir. enemy 
    }

   public void WalkUpAI()
    {
            mCntrl.Up();
    }

   public void WalkDownAI()
    {
            mCntrl.Down();
    }

    public void WalkLeftAI()
    {
        mCntrl.Left();
    }

    public void WalkRightAI()
    {
        mCntrl.Right();
    }


    private void OnCollisionEnter(Collision collision)
    {

        //if enemy collides with anything then turn around 90 and resume walking forward
        if (collision.gameObject.tag == "bUp" || collision.gameObject.tag == "bDown" || collision.gameObject.tag == "bLeft" || collision.gameObject.tag == "bRight")
        {
            Instantiate(_brokenCube, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "key")
        {
            //no need for anything just should push key around
        }
        else if(collision.gameObject.tag=="Player")
        {
            Destroy(GameManager.gMan.player);
        }
        else
        {
            print("ran into wall");
            switch (dirAI.enemyfDir)
            {
                case DirectionAI.EnemyFaceDirection.Up:
                    dirAI.enemyfDir = DirectionAI.EnemyFaceDirection.Down;
                    break;
                case DirectionAI.EnemyFaceDirection.Down:
                    dirAI.enemyfDir = DirectionAI.EnemyFaceDirection.Up;
                    break;
                case DirectionAI.EnemyFaceDirection.Left:
                    dirAI.enemyfDir = DirectionAI.EnemyFaceDirection.Right;
                    break;
                case DirectionAI.EnemyFaceDirection.Right:
                    dirAI.enemyfDir = DirectionAI.EnemyFaceDirection.Left;
                    break;
            }

        }
    }
   
    void TurnTimeTracker()
    {
        turnTime += Time.deltaTime;         //this should trigger a co-routine to add more 'life like'
        if (turnTime >= 5f)
        {
            turnTime = 0;
            RandomDirection();
        }
    }

    void RandomDirection()
    {
        //up random range #'s
        
        //GameManager.gMan.mDir.enemyfDir = (MoveDirection.EnemyFaceDirection)Random.Range(0, 3);
        switch (dirAI.enemyfDir)
        {
            case DirectionAI.EnemyFaceDirection.Up:
                dirAI.enemyfDir = (DirectionAI.EnemyFaceDirection)dirAI.upTurn;
                break;
            case DirectionAI.EnemyFaceDirection.Down:
                dirAI.enemyfDir = (DirectionAI.EnemyFaceDirection)dirAI.downTurn;
                break;
            case DirectionAI.EnemyFaceDirection.Left:
                dirAI.enemyfDir = (DirectionAI.EnemyFaceDirection)dirAI.leftTurn;
                break;
            case DirectionAI.EnemyFaceDirection.Right:
                dirAI.enemyfDir = (DirectionAI.EnemyFaceDirection)dirAI.rightTurn;
                break;
        }
    }
}




