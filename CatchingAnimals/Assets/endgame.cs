using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
    {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene("MainMenu");
		}
        if (other.tag == "Player")
        {
            Invoke("EndGameFunc",5);
        }

    }
    void EndGameFunc()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
