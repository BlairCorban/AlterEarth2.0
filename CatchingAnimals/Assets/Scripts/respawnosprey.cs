using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnosprey : MonoBehaviour {
    public SphereCollider sph;
    public Transform playertr;
    public GameObject ospreyprefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!PlayerHandler.isOsp)
        {
            if(!sph.bounds.Contains(playertr.position))
            {
                if(!GetComponent<MeshRenderer>().isVisible)
                {
                    Instantiate(ospreyprefab,new Vector3(-167.7919f, 9.39f, -32.39216f), ospreyprefab.transform.rotation);
                    PlayerHandler.isOsp = true;
                }
            }
        }
	}
}
