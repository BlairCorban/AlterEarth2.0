using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter()
    {
        Debug.Log("collision");
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "safecollide")
        {
            Debug.Log(other.name);
            Destroy(gameObject);
        }
        
    }
}
