using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freshspawn : MonoBehaviour {
    public bool isfresh;
	// Use this for initialization
	void Start () {
        isfresh = true;
        Invoke("NotFresh", 3f);
	}
	
	void NotFresh()
    {
        isfresh = false;
    }
}
