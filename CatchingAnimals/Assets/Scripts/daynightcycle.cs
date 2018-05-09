using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightcycle : MonoBehaviour {
    public float rotationSpeed;
	
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, rotationSpeed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
	}
}
