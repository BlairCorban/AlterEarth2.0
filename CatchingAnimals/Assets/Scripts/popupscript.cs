using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupscript : MonoBehaviour {
	public Text goalName;
	public Image picture;
	public Sprite[] textures;
	int timer = 0;
	string name;
	string goal;

	//int changeDirectiontimer = 60;
	// Use this for initialization
	//void setup(string setname,string setgoal,int active);

	// Update is called once per frame
	void Update () {
		if (timer <= 120) {
			transform.Translate (0,1.5f, 0);
		} else {
			if (timer == 300) {
				Destroy (gameObject);
			}
			transform.Translate (0,-1.5f, 0);
		}
		timer++;
	}
	public void setup(string setname,string setgoal){

		name = setname;

		Debug.Log ("call");
		goal = setgoal;
		switch (name) {
		case "Green":
			picture.sprite = textures[0];
			break;
		default:
			Debug.Log ("call");
			break;
		}
	}
}
