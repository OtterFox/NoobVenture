using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Needs MoveCntrller class and a Rigidbody to use this class on an object
[RequireComponent(typeof(Rigidbody))]

public class UserInput : MonoBehaviour {

  // GameObject gM;
    Projectiles proj;
   [SerializeField] MoveCntrller mCntrl;
    

    void Start ()
    {
        //Reference MoveCntrller script to use its methods in this class.
        //move = gM.GetComponent<MoveCntrller>();
        //gM = GameObject.FindGameObjectWithTag("GameMan");
        proj = GameObject.FindGameObjectWithTag("GameMan").gameObject.GetComponent<Projectiles>();  //calls proj script and references correctly
    }

    // Update is called once per frame
    void Update ()
    {
        MoveUp();
        MoveDown();
        MoveLeft();
        MoveRight();
        Shoot();
    }
    

    public void MoveUp()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            mCntrl.Up();
        }
    }

    public void MoveDown()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            mCntrl.Down();
        }
    }

    public void MoveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            mCntrl.Left();
        }
    }

    public void MoveRight()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mCntrl.Right();
        }
    }


    private void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if(Physics.Raycast(ray, out hit, 10))
            {
                Debug.DrawLine(ray.origin, hit.point);
            }
            proj.CreateBullet();
        }

        

    }


   
}
