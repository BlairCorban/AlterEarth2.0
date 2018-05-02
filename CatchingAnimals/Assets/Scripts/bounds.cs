using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounds : MonoBehaviour {

    void Start()
    {
        Mesh m = GetComponent<MeshFilter>().mesh;
        m.bounds = new Bounds(Vector3.zero, Vector3.one * 2000);
        //mesh.bounds is in local/object space, so
        //setting a center of zero and extents of 2000 will
        //expand the bounds into a box 2000 units wide around
        //the center of the object
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
