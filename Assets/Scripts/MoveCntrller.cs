using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCntrller : MonoBehaviour {
    //general player/ai movement
    public float _speed = 5;
    public bool isUp;
    public bool isDown;
    public bool isLeft;
    public bool isRight;

    void Start ()
    {
        
    }
		
	void Update ()
    {
        
    }

    public void Up()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        // transform.position += Vector3.up * _speed * Time.deltaTime;
        isUp = true;
        isDown = false;
        isLeft = false;
        isRight = false;
       // print("Moved?");   
    }

    public void Down()
    {
        transform.Translate(-Vector3.up * _speed * Time.deltaTime);
        //transform.position += -Vector3.up * _speed * Time.deltaTime;
        isUp = false;
        isDown = true;
        isLeft = false;
        isRight = false;
    }

    public void Left()
    {
        transform.Translate(-Vector3.right * _speed * Time.deltaTime);
        isUp = false;
        isDown = false;
        isLeft = true;
        isRight = false;
    }

    public void Right()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        isUp = false;
        isDown = false;
        isLeft = false;
        isRight = true;
    }






}
