using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmoveonspawn : MonoBehaviour {
	public float movementspeed;
    public int scale;

    void Start()
    {
        scale = 0;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
        if (PlayerHandler.isgun1 == false)
        {
            if (scale < 15)
            {
                this.transform.localScale = new Vector3(this.transform.localScale.x + 0.1f, this.transform.localScale.y + 0.1f, this.transform.localScale.z + 0.1f);
                scale += 1;
            }
        }
	}

}
