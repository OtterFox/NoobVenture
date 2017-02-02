using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    //All calls should go through game manager. 
    
    public Transform tUp;
    public Transform tDown;
    public Transform tLeft;
    public Transform tRight;

    public MoveDirection moveDir;

    void Awake ()
    {
        MoveDirection moveDir = GameObject.Find("Player").GetComponent<MoveDirection>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    public void CreateBullet()
    {

        switch(moveDir.playerfDir)
        {
            case MoveDirection.FaceDirection.Up:
                GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tUp.position, tUp.rotation);
                GameManager.gMan.bulletPrefab.tag = "bUp";
                GameManager.gMan.pMove.BulletMove();
                break;

            case MoveDirection.FaceDirection.Down:
                GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tDown.position, tDown.rotation);
                GameManager.gMan.bulletPrefab.tag = "bDown";
                GameManager.gMan.pMove.BulletMove();
                break;

            case MoveDirection.FaceDirection.Left:
                GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tLeft.position, tLeft.rotation);
                GameManager.gMan.bulletPrefab.tag = "bLeft";
                GameManager.gMan.pMove.BulletMove();
                break;

            case MoveDirection.FaceDirection.Right:
                GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tRight.position, tRight.rotation);
                GameManager.gMan.bulletPrefab.tag = "bRight";
                GameManager.gMan.pMove.BulletMove();
                break;
        }



        //print(GameManager.gMan.mDir.playerfDir);
        //switch (GameManager.gMan.mDir.playerfDir)    <----- notice this fucked the entire switch statement
        //    {
        //        case MoveDirection.FaceDirection.Up:

        //        GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tUp.position, tUp.rotation);
        //        GameManager.gMan.bulletPrefab.tag="bUp";
        //        GameManager.gMan.pMove.BulletMove();
        //        break;

        //        case MoveDirection.FaceDirection.Down:

        //        GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tDown.position, tDown.rotation);
        //        GameManager.gMan.bulletPrefab.tag = "bDown";
        //        GameManager.gMan.pMove.BulletMove();
        //        break;

        //        case MoveDirection.FaceDirection.Left:
        //        GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tLeft.position, tLeft.rotation);
        //        GameManager.gMan.bulletPrefab.tag = "bLeft";
        //        GameManager.gMan.pMove.BulletMove();
        //        break;

        //        case MoveDirection.FaceDirection.Right:
        //        GameManager.gMan.bulletPrefab = Instantiate(GameManager.gMan.bullet, tRight.position, tRight.rotation);
        //        GameManager.gMan.bulletPrefab.tag = "bRight";
        //        GameManager.gMan.pMove.BulletMove();
        //        break;

    }
    }


   
      
//}

//old instantiate code
// print("bullet?");
//Instantiate(bulletPrefab, tUp.position, tUp.rotation);
//if (move.isUp)
//{
//    Instantiate(bulletPrefab, tUp.position, tUp.rotation);
//    //isTranUp = true;
//    //bulletPrefab.transform.position += Vector3.up * 10;
//}
//if (move.isDown)
//{
//    Instantiate(bulletPrefab, tDown.position, tDown.rotation);
//}
//if (move.isLeft)
//{
//    Instantiate(bulletPrefab, tLeft.position, tLeft.rotation);
//}
//if (move.isRight)
//{
//    Instantiate(bulletPrefab, tRight.position, tRight.rotation);
//    print("bullet RIGHT?");
//}