using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveDirection : MonoBehaviour
{
    //player movement
    public enum FaceDirection { Up=0, Down=1, Left=2, Right=3 }  
    public FaceDirection playerfDir;
    public MoveCntrller pMove;

    void Start()
    {
       playerfDir = FaceDirection.Up;
        MoveCntrller pMove = GameObject.Find("Player").GetComponent<MoveCntrller>();    
    }


    private void Update()
    {
        PlayerFaceDir();
    }
    
    public void PlayerFaceDir()
    {
        //switch(playerfDir)
        //{
        //    case FaceDirection.Up:
        //        pMove.isUp=true;
        //        break;
        //    case FaceDirection.Down:
        //        playerfDir = FaceDirection.Down;
        //        break;
        //    case FaceDirection.Left:
        //        playerfDir = FaceDirection.Left;
        //        break;
        //    case FaceDirection.Right:
        //        playerfDir = FaceDirection.Right;
        //        break;
        //}

        //old if statments instead of case/switch
        if (pMove.isUp)
        {
            playerfDir = FaceDirection.Up;
        }
        if (pMove.isDown)
        {
            playerfDir = FaceDirection.Down;
        }
        if (pMove.isLeft)
        {
            playerfDir = FaceDirection.Left;
        }
        if (pMove.isRight)
        {
            playerfDir = FaceDirection.Right;
        }
    }
}




