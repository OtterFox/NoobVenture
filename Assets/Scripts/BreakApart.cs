using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakApart : MonoBehaviour {

    [SerializeField] GameObject _brokenBox;
    [SerializeField] GameObject _key;
    Rigidbody keyRB;
    float bTimer;
    bool bTimerOn;

    private void Awake()
    {
        keyRB = _key.GetComponent<Rigidbody>();
        _key.SetActive(false);
        
    } 

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(_brokenBox, transform.position, transform.rotation);
        _key.SetActive(true);
        Destroy(gameObject);
        
    }

    
    

   

}
