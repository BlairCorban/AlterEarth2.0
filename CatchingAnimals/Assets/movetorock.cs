using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetorock : MonoBehaviour {
    public int whichrock;
    public GameObject idol1;
    public GameObject idol2;
    public GameObject idol3;
    public GameObject transidol1;
    public GameObject transidol2;
    public GameObject transidol3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
        if (other.tag == "Player")
        {
            if (whichrock == 1)
            {
                this.gameObject.SetActive(false);
                transidol1.SetActive(false);
                idol1.SetActive(true);
                stats.idolscollected += 1;
            }
            if (whichrock == 2)
            {
                this.gameObject.SetActive(false);
                transidol2.SetActive(false);
                idol2.SetActive(true);
                stats.idolscollected += 1;
            }
            if (whichrock == 3)
            {
                this.gameObject.SetActive(false);
                transidol3.SetActive(false);
                idol3.SetActive(true);
                stats.idolscollected += 1;
            }
        }
        
    }
}
