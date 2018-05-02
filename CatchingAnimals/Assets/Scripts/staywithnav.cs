using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staywithnav : MonoBehaviour {
    public Transform tr1;
    public Transform tr2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tr1.position = tr2.position + new Vector3(0.1f,0.1f,0.1f);
        tr1.rotation = tr2.rotation;
	}
}
