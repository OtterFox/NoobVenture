using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    [SerializeField] Camera _camera;
    [SerializeField] GameObject _player;
    public Transform tran1,tran2, tran3, tran4;         //Changed to serialized in future, do not want other classes changing
    public bool inRm1, inRm2, inRm3, inRm4;        //Place in enum later
   
	void Start ()
    {
        inRm1 = true;
	}
	
	void Update ()
    {
        //RmOne();
        //RmTwo();

    }

    public void CameraRm1(bool _inRm1)
    {
        _camera.transform.position = new Vector3(tran1.position.x, tran1.position.y, -10);
        inRm1 = true;
        inRm2 = false;
        inRm3 = false;
        inRm4 = false;
    }

    public void CameraRm2(bool _inRm2)
    {
        _camera.transform.position = new Vector3(tran2.position.x, tran2.position.y, -10);
        inRm1 = false;
        inRm2 = true;
        inRm3 = false;
        inRm4 = false;
    }

    public void CameraRm3(bool _inRm3)
    {
        _camera.transform.position = new Vector3(tran3.position.x, tran3.position.y, -10);
        inRm1 = false;
        inRm2 = false;
        inRm3 = true;
        inRm4 = false;
    }

    public void CameraRm4(bool _inRm4)
    {
        _camera.transform.position = new Vector3(tran4.position.x, tran4.position.y, -10);
        inRm1 = false;
        inRm2 = false;
        inRm3 = true;
        inRm4 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (inRm2)
        {
            CameraRm3(false);
            //get fancy and 'auto' move player throughdoor when camera moves
            _player.transform.position += new Vector3(2.5f, 0, 0);
        }
        else if (inRm3)
        {
            CameraRm2(false);
            //get fancy and move player throughdoor when camera moves
            _player.transform.position -= new Vector3(2.5f, 0, 0);
        }
    }

}


////use a class to move camera based on the room player has entered
//public void RmOne()
//{
//    //First we will test that ou camera works.
//    if(Input.GetKey(KeyCode.UpArrow) && !_inRm1) //add bool and explain/show expample why it is importan moves without it
//    {
//        transform.position = new Vector3(tran1.position.x, tran1.position.y, -10);
//        //Vector3 pos = tran1.position;
//        //transform.position = pos;
//        _inRm1 = true;
//        _inRm2 = false;
//        _inRm3 = false;
//        _inRm4 = false;
//    }

//    if (Input.GetKey(KeyCode.LeftArrow) && !_inRm3)
//    {


//        transform.position = new Vector3(tran3.position.x, tran3.position.y, -10);
//        //Vector3 pos = tran2.position;
//        //transform.position = pos;
//        _inRm1 = false;
//        _inRm2 = false;
//        _inRm3 = true;
//        _inRm4 = false;
//    }
//    if (Input.GetKey(KeyCode.RightArrow) && !_inRm4)
//    {
//        transform.position = new Vector3(tran4.position.x, tran4.position.y, -10);
//        //Vector3 pos = tran2.position;
//        //transform.position = pos;
//        _inRm1 = false;
//        _inRm2 = false;
//        _inRm3 = false;
//        _inRm4 = true;
//    }
//}

//void RmTwo()
//{
//    if (Input.GetKey(KeyCode.DownArrow) && !_inRm2)
//    {
//        transform.position = new Vector3(tran2.position.x, tran2.position.y, -10);
//        //Vector3 pos = tran2.position;
//        //transform.position = pos;
//        _inRm1 = false;
//        _inRm2 = true;
//        _inRm3 = false;
//        _inRm4 = false;
//    }
//}