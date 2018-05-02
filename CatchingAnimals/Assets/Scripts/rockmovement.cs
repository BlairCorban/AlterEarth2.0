using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmovement : MonoBehaviour {
    public GameObject idol1;
    public GameObject idol2;
    public GameObject idol3;
	private bool meme;
	// Use this for initialization
	void Start () {
        Debug.Log("idols collected: " + stats.idolscollected);
		meme = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			stats.idolscollected += 1;
		}
		if (stats.idolscollected == 3) {			
			if (meme) 
			{
				Invoke ("rockmove", 0.01f);
				this.transform.position += new Vector3(-5,0,-5);
				meme = false;
			}

		}
	}
    
    void rockmove()
    {
		idol1.transform.position += new Vector3(-5,0,-5);
		idol2.transform.position += new Vector3(-5,0,-5);
		idol3.transform.position += new Vector3(-5,0,-5);
        
    }
}
