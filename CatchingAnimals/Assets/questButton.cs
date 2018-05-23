using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class questButton : MonoBehaviour {
	quest questInfo;
	showimage QuesImage;
	public Button controlButton;
	public Text owntext;
	int loctation;
	// Use this for initialization
	void Start () {
		questInfo = FindObjectOfType<quest>();
		QuesImage = FindObjectOfType<showimage>();
	}
	
	// Update is called once per frame
	void Update () {
		Button onlybutton = controlButton.GetComponent<Button>();
		onlybutton.onClick.AddListener (change);
	}
	void change(){
		QuesImage.Updatelookedatquest(questInfo.quests[loctation],questInfo.current[loctation],questInfo.max[loctation]);
	}
	public void placement(string name,int place){

		loctation = place;
		transform.Translate (-400,-30.5f*loctation, 0);
		owntext.text = name;
	}
}
