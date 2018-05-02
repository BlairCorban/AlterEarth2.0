using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("idle to sleep", -1, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("sleep to idle", -1, 0f);
        }
	}
}
