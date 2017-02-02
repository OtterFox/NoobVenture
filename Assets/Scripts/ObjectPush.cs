using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPush : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        print("col?");
        if(collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.RightControl))
        {
            rb.isKinematic = false;
            print("CNTRL col?");
        }
    }
}
