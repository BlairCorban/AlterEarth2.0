using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsButton : MonoBehaviour {
	public Button MainButton;
	// Use this for initialization
	void Start () {
		
		Button MB = MainButton.GetComponent<Button>();
		MB.onClick.AddListener(MainMenu);
	} 
	// Update is called once per frame
	void MainMenu () {
		Debug.Log("load main");
		SceneManager.LoadScene("MainMenu");
	}
}
