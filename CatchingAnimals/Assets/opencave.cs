using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opencave : MonoBehaviour {
    public GameObject opencaveobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHandler.isBushCap && PlayerHandler.isOspCap && PlayerHandler.isUFOCap)
        {
            opencaveobj.SetActive(true);
            transform.gameObject.SetActive(false);
        }

	}
}
