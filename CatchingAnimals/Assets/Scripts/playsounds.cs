using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsounds : MonoBehaviour {
    public AudioSource src;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(stats.canfire)
            {
                if(stats.AmmoInt >0)
                {
                    src.Play();
                }
                
            }
        }
	}
}
