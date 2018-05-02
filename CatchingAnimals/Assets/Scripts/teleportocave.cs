using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportocave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("teleport!");
            other.gameObject.transform.position = new Vector3(-10.15f,-218,52.78f);
        }
    }
}
