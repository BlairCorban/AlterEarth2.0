using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stats : MonoBehaviour {
    public static int bushmobs;
    public static int capturedmobs;
    public static int idolscollected;
    public static bool isOsp;
    public static int batteries;
    public static bool canfire;
	public static bool isospcaptured;
	public GameObject gun1;
	public GameObject gun2;
	public bool isgun1;
    public static int AmmoInt;
	public Text idol;
	public Text bush;
	public Text osprey;
	public Text ammotxt;
	public Text batteriestxt;

	// Use this for initialization
	void Start () {
        bushmobs = 0;
        capturedmobs = 0;
        idolscollected = 0;
        isOsp = false;
        batteries = 1;
        canfire = true;
        AmmoInt = 6;
		isgun1 = true;
		isospcaptured = false;
	}
	
	// Update is called once per frame
	void Update () {


		idol.text = idolscollected.ToString();
		bush.text = capturedmobs.ToString();
		if (isospcaptured) {
			osprey.text = "1";
		} 
		ammotxt.text = AmmoInt.ToString();
		batteriestxt.text = batteries.ToString();






		if (Input.GetKeyDown (KeyCode.E)) {
			if (isgun1) {
				gun1.SetActive (false);
				gun2.SetActive (true);
				isgun1 = false;
						
			} 
			else {
				gun2.SetActive (false);
				gun1.SetActive (true);
				isgun1 = true;
			}
		}
	}
}
