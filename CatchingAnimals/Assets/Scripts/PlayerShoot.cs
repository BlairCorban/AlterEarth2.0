using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public bool isShoot;
	public Transform trself;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		Debug.Log (PlayerHandler.AmmoInt);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
            if(PlayerHandler.canfire)
            {
                if (PlayerHandler.AmmoInt > 0)
			    {
				    Instantiate (prefab, trself.position, trself.rotation);
                    PlayerHandler.AmmoInt -= 1;
                    Debug.Log(PlayerHandler.AmmoInt);
                    Debug.Log("batteries: " + PlayerHandler.batteries);
                    PlayerHandler.canfire = false;
                    Invoke("firerate", .5f);
			    }
            }

		}
		if (Input.GetKeyDown (KeyCode.R))
		{
            if(PlayerHandler.batteries>0)
            {
                PlayerHandler.AmmoInt = 6;
                Debug.Log(PlayerHandler.AmmoInt);
                PlayerHandler.batteries -= 1;
            }
			
		}
	}
    void firerate()
    {
        PlayerHandler.canfire = true;
    }
}
