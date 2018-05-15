using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.tag == "creature")
        {         
 
            Debug.Log("despawn!");
            Destroy(other.gameObject);
            PlayerHandler.bushmobs -= 1;
        }
    }
	
}
