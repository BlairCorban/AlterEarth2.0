using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour {
    public Camera camera;
    public GameObject saddle;
    testpopup popup;
	// Use this for initialization
	void Start () {
        popup = FindObjectOfType<testpopup>();
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
                // if you press e on a wood destroy item and add 1 to wood value
                if(objectHit.name == "wood" || objectHit.name == "wood(Clone)")
                {
                    Destroy(objectHit.gameObject);
                    PlayerHandler.woodInventory += 1;
                    popup.makePop("Wood", "You Collected Some Wood!");
                    //PlayerHandler.SendSimplePopup("You collected some wood!");
                }
                else if(objectHit.name == "house")
                {
                    if(PlayerHandler.woodInventory >= 5)
                    {

                        objectHit.localScale = objectHit.localScale + objectHit.localScale;
                        PlayerHandler.woodInventory -= 5;
                        PlayerHandler.SendSimplePopup("You built a house? That cost 5 wood.");
                    }
                }
                if (objectHit.name == "UFO" || objectHit.name == "UFO(Clone)")
                {
                    Destroy(objectHit.gameObject);
                    PlayerHandler.electronicsInventory += 1;
                    PlayerHandler.SendSimplePopup("You collected some electronics!");
                }
                if (objectHit.name == "Fruit")
                {
                    Destroy(objectHit.gameObject);
                    PlayerHandler.fruitInventory += 1;
                    PlayerHandler.SendSimplePopup("You picked up a fruit! You can tame the Ceph using this...");
                }
                if (objectHit.name == "Ceph")
                {
                    if (PlayerHandler.fruitInventory >= 1)
                    {
                        saddle.SetActive(true);
                        PlayerHandler.m_bPlayerCanMount = true;
                        PlayerHandler.SendSimplePopup("The Ceph has been succesfully tamed using a fruit!");
                    }
                }
                
            }
        }
	}
}
