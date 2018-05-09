using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class quest : MonoBehaviour {

	struct QuestList{
		public string questObjective;
		public string Questname;
		public string Description;
		public int current;
		public int total;

		public QuestList(string q1,string q2,string d1,int c1,int t1){
			questObjective = q1;
			Questname = q2;
			Description = d1;
			current = c1;
			total = t1;
		}
	}

	private QuestList[] Quest;
	// Use this for initialization
	void Start () {
		Quest[0] = new QuestList("Gloms",
			"Returning the Favor",
			"Gloms have took some stuff from your home as well as damage it, time to hunter them down",
			0,
			15);
		Quest[1] = new QuestList("dummy",
			"A Favor",
			"Gloms have took some stuff from your home as well as damage it, time to hunter them down",
			5,
			15);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.O)) {
			for (int b = 0; b < Quest.Length; b++) {
				print (Quest[b].Questname);
				print (Quest[b].Description);
				print (Quest[b].current+"/"+ Quest[b].total);
				}
			}

	}
}
