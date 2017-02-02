using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {
    [SerializeField] GameObject doorOne;
    [SerializeField] CameraMove cam;
	// Use this for initialization
	void Start () {
        GameObject doorOne = GetComponent<GameObject>();
        CameraMove cam = GetComponent<CameraMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "key")
        {
            doorOne.transform.position -= new Vector3(2.5f, 0, 0);
          
            }
        }
    }

