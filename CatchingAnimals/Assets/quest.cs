using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class quest : MonoBehaviour {
	public List <string> questsname;
	public  List <string> quests;
	public  List <int> current;
	public  List <int> max;
	public GameObject home;
	public GameObject questbook;
	Vector3  v3 = new Vector3(0,0,0); 
	Quaternion q4 = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		add ("this 1", "this is sssss1", 0, 4);
		add ("Caputer", "you need to get 4 green guys", 0, 4);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			//create game object quest
			GameObject spawn = Instantiate (questbook,v3,q4) ;
			Cursor.visible = true;
			spawn.transform.SetParent (home.transform,false);
		}	
	}
	void add(string name,string info,int Cur,int goal){
		questsname.Add(name);
		quests.Add(info); 
		current.Add(Cur); 
		max.Add(goal); 
	}
	void increase(string name, int Cur){
		for (int i = 0; i < questsname.Count+1; i++) {
			if (questsname[i-1] == name) {
				current [i-1] = Cur;
				if (current [i-1] == max[i-1]) {
					//quest complete
				}
			}
		}
	}
}

//Destroy(GameObject);