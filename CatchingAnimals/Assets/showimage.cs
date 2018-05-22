using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showimage : MonoBehaviour {
	public Text goalName;
	public Text Currentss;
	public Text Maxss;
	public GameObject home;
	public GameObject button;
	quest questInfo;
	Vector3  v3 = new Vector3(0,0,0); 
	Quaternion q4 = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		//Debug.Log ("start");
		questInfo = FindObjectOfType<quest>();
		//Debug.Log ("start");
		Debug.Log (questInfo.quests[0]);
		goalName.text = questInfo.quests[0];
		Currentss.text = questInfo.current[0].ToString();
		Maxss.text = questInfo.max[0].ToString();
		for (int i = 1; i < questInfo.quests.Count+1; i++) {
			GameObject spawn = Instantiate (button,v3,q4) ;
			v3.x = v3.x - .2f;
			spawn.transform.SetParent (home.transform,false);
			spawn.GetComponent<questButton> ().placement (questInfo.questsname[i-1],i-1);
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) {
			Cursor.visible = false;
			Destroy(gameObject);
		}
	}

	public void Updatelookedatquest (string wordds,int cureent,int masx) {
		goalName.text = wordds;
		Currentss.text =cureent.ToString();
		Maxss.text = masx.ToString();
	}
}
