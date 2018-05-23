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
	void Start () {
		transform.Translate (0,-41.5f, 0);
	}
	// Update is called once per frame
	void Update () {
		if (timer <= 240) {
			transform.Translate (0,0.25f, 0);
		} else {
			if (timer == 600) {
				Destroy (gameObject);
			}
			transform.Translate (0,-0.25f, 0);
		}
		timer++;
	}
	public void setup(string setname,string setgoal){
		transform.Translate (0,-320.5f, 0);
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
