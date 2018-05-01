using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoposprey : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "creature")
        {
            Debug.Log("respawn on box");
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
