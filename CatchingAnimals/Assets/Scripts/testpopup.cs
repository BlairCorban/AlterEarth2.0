using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testpopup : MonoBehaviour {
	public GameObject pop;
	public GameObject home;
	 Vector3  v3 = new Vector3(0,0,0); 
	 Quaternion q4 = new Quaternion(0,0,0,0);
	//public popupscript popUp;
	// Use this for initialization
	// Update is called once per frame
	void Start () {
		//popUp = gameObject.GetComponent<popupscript>();

	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.M)) {
			makePop("ree", "cature green");

			//spawn.transform.localPosition = new Vector3(300,200,0);
			//popUp.setup ( "greem","greem Capture");
		}
	}
	public void lauchpop(int num){
		Debug.Log ("call");
		makePop("wood", "gain wood");
}
	public void makePop(string name, string texts){
		GameObject spawn = Instantiate (pop,v3,q4) ;
		Debug.Log ("call");
		spawn.transform.SetParent (home.transform,false);
		Debug.Log ("call");
		spawn.GetComponent<popupscript>().setup( name,texts);
		Debug.Log ("call");
	}
}
