using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour {
    public Camera camera;
    public GameObject saddle;
    public GameObject House;
    public GameObject bridge;
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
                else if(objectHit.name == "HouseSign")
                {
                    if(PlayerHandler.woodInventory >= 25)
                    {
                        House.SetActive(true);
                        PlayerHandler.woodInventory -= 25;
                    }
                    else
                    {
                        popup.makePop("Wood", "Collect 25 Wood And Come Back Here To Build a House!");
                    }
                }
                else if (objectHit.name == "BridgeSign")
                {
                    if (PlayerHandler.woodInventory >= 15)
                    {
                        bridge.SetActive(true);
                        PlayerHandler.woodInventory -= 15;
                    }
                    else
                    {
                        popup.makePop("Wood", "Maybe You Could Build Something Here To Get To That Thing On The Rock Over There, Come Back With 15 Wood!");
                    }
                }
                else if (objectHit.name == "CaveSign")
                {
                    popup.makePop("Wood", "Look At Those Symbols Above The Cave. Looks Like You Cant Enter Until You've Done Something To Do With Those Symbols!");
                }
                else if (objectHit.name == "Sign1")
                {
                    popup.makePop("Bush", "Welcome To AlterEarth, Capture Crazy Creatures and Explore The Wonderful Environment To See Everything This World has To Offer!");
                }
                else if (objectHit.name == "Sign2")
                {
                    popup.makePop("Fruit", "Shoot Creatures With Your Gun With Left Click and Capture Them By Running Over Them Or Pick Up Items By Looking At Them And Pressing E!");
                }
                else if (objectHit.name == "Sign3")
                {
                    popup.makePop("Wood", "Enjoy And Have Fun!");
                }
                if (objectHit.name == "UFO" || objectHit.name == "UFO(Clone)")
                {
                    PlayerHandler.isUFOCap = true;
                    Destroy(objectHit.gameObject);
                    PlayerHandler.electronicsInventory += 1;
                    //PlayerHandler.SendSimplePopup("You collected some electronics!");
                }
                if (objectHit.name == "Fruit")
                {
                    Destroy(objectHit.gameObject);
                    PlayerHandler.fruitInventory += 1;
                    popup.makePop("Fruit", "You Collected The CephFruit, I Wonder If That Big Creature W ould Appreciate This");
                    //PlayerHandler.SendSimplePopup("You picked up a fruit! You can tame the Ceph using this...");
                }
                if (objectHit.name == "Ceph")
                {
                    if (PlayerHandler.fruitInventory >= 1)
                    {
                        saddle.SetActive(true);
                        popup.makePop("Fruit", "You Fed The CephFruit To The Cephaderm, Now It Has A Saddle, Maybe You Could Ride Him!");
                        PlayerHandler.m_bPlayerCanMount = true;
                        //PlayerHandler.SendSimplePopup("The Ceph has been succesfully tamed using a fruit!");
                    }
                }
                
            }
        }
	}
}
