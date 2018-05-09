using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class inventory : MonoBehaviour {

	struct INList{
		public string name;
		public int count;
	
	public INList(string n1,int c1){
		name= n1;
		count = c1;
		}
	}

	private INList[] I;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			for (int b = 0; b < I.Length; b++) {
				print (I[b].name +" "+ I[b].count);
			}
		}
	}

	bool Add(string item, int amount){
		for (int b = 0; b < I.Length; b++) {
			if (item == I[b].name) {
				I[b].count= I[b].count+amount;
				return false; // changed
			}
		}
		I[I.Length+1] = new INList(item,amount);
		return true; //add
	}

	bool Remove(string item, int amount){
		for (int b = 0; b < I.Length; b++) {
			if (item == I[b].name) {
				I[b].count= I[b].count-amount;
				return false; // changed
			}
		}
		print ("error don't have item");
		return true; //add
	}
}
