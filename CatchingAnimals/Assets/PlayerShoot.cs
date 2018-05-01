using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public bool isShoot;
	public Transform trself;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		Debug.Log (stats.AmmoInt);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
            if(stats.canfire)
            {
                if (stats.AmmoInt > 0)
			    {
				    Instantiate (prefab, trself.position, trself.rotation);
                    stats.AmmoInt -= 1;
                    Debug.Log(stats.AmmoInt);
                    Debug.Log("batteries: " + stats.batteries);
                    stats.canfire = false;
                    Invoke("firerate", .5f);
			    }
            }

		}
		if (Input.GetKeyDown (KeyCode.R))
		{
            if(stats.batteries>0)
            {
                stats.AmmoInt = 6;
                Debug.Log(stats.AmmoInt);
                stats.batteries -= 1;
            }
			
		}
	}
    void firerate()
    {
        stats.canfire = true;
    }
}
