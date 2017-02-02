using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBroken : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("DestroyBlocks");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //In future update make object fade away
    IEnumerator DestroyBlocks()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
