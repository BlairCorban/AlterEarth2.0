using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobblerAnimController : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) 
		{
			anim.Play("Gobbler-Shoot");
		}
		if (Input.GetKeyDown ("e")) 
		{
			anim.Play("Gobbler-Deactivate");
		}
		if (Input.GetKeyDown ("q")) 
		{
			anim.Play("Gobbler-Activate");
		}
	}
}