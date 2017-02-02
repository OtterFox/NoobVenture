using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    [SerializeField] CameraMove cam;
    [SerializeField] GameObject key;
    [SerializeField] GameObject door;
    [SerializeField] GameObject player; //for moving player to next room after touching door collider

    
    // Use this for initialization
    void Start () {
        CameraMove cam = GetComponent<CameraMove>();
        GameObject player = GetComponent<GameObject>();
        GameObject door = GetComponent<GameObject>();
        GameObject key = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Open()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
           
        

}

private void OnTriggerExit(Collider other)
    {
        door.transform.position += new Vector3(2.5f, 0, 0);
        //transform.position -= new Vector3(2.5f, 0, 0);
        if (cam.inRm2)
        {
            cam.CameraRm1(false);
            //get fancy and 'auto' move player throughdoor when camera moves
            player.transform.position -= new Vector3(0, 2.5f, 0);
        }
        if (cam.inRm1)
        {
            cam.CameraRm2(false);
            //get fancy and move player throughdoor when camera moves
            player.transform.position += new Vector3(0, 2.5f, 0);
        }
        //and send key back to its starting position
        key.transform.position = new Vector3(-10.72f, -2.65f, 0.02f);
    }

    
}
