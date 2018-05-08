using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour {
    public Camera camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10))
            {
                GameObject objectHit = hit.transform.gameObject;
                if(objectHit.name == "wood" || objectHit.name == "wood(Clone)")
                {
                    Destroy(objectHit);
                    stats.woodInventory += 1;
                }
                
            }
        }
	}
}
