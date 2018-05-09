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

            if (Physics.Raycast(ray, out hit, 5))
            {
                Transform objectHit = hit.transform;
                if(objectHit.name == "wood" || objectHit.name == "wood(Clone)")
                {
                    Destroy(objectHit.gameObject);
                    stats.woodInventory += 1;
                }
                else if(objectHit.name == "house")
                {
                    if(stats.woodInventory >= 5)
                    {

                        objectHit.localScale = objectHit.localScale + objectHit.localScale;
                        stats.woodInventory -= 5;
                    }
                }
                
            }
        }
	}
}
