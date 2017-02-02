using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MoveCntrller {

    GameManager gman;

    
    // Use this for initialization
    void Awake ()
    {
        gman = GameObject.FindGameObjectWithTag("GameMan").GetComponent<GameManager>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        BulletMove();
    }
    
    public void BulletMove()
    {
        _speed = 7;         //sets speed of bullet. Will not effect player speed
        if(gameObject.tag == "bUp")
        {
            Up();
        }
        else if (gameObject.tag == "bDown")
        {
            Down();
            //transform.position -= Vector3.up * 10 * Time.deltaTime;
        }
        else if(gameObject.tag == "bLeft")
        {
            Left();
        }
        else if (gameObject.tag == "bRight")
        {
            Right();
        }
        

    }

    public void OnCollisionEnter(Collision collision)
    {
        

        Destroy(gameObject);
    }





}
