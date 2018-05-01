using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour {

	// Use this for initialization
	public Button MainButton;
	public Button ExitButton;

	// Use this for initialization
	void Start () {
		//public Button yourButton;
		Button MB = MainButton.GetComponent<Button>();
		Button EB = ExitButton.GetComponent<Button>();
		MB.onClick.AddListener(MainMenu);
		EB.onClick.AddListener(Exit);
	} 

	// Update is called once per frame
	void Update () {

	}
	void MainMenu()
	{
		Debug.Log("load main");
		SceneManager.LoadScene("MainMenu");
	}
	void Exit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
