using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour {
	public Button GameButton;
	public Button MenuButton;
	public Button ExitButton;

	// Use this for initialization
	void Start () {
		//public Button yourButton;
		Button GB = GameButton.GetComponent<Button>();
		Button MB = MenuButton.GetComponent<Button>();
		Button EB = ExitButton.GetComponent<Button>();
		GB.onClick.AddListener(StartGame);
		MB.onClick.AddListener(ToMenu);
		EB.onClick.AddListener(Quit);
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
	void StartGame()
	{
		Debug.Log("Start Game");
		SceneManager.LoadScene("main");
	}
	void ToMenu()
	{
		Debug.Log("Menu open");
		SceneManager.LoadScene("Controls");
	}
	void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
