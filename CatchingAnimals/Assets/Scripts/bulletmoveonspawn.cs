using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmoveonspawn : MonoBehaviour {
	public Transform trself;
	public float movementspeed;
	
	// Update is called once per frame
	void Update () {
		trself.Translate (Vector3.forward * movementspeed * Time.deltaTime);        
	}

}
