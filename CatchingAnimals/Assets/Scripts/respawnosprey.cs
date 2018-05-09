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
                    Instantiate(ospreyprefab,new Vector3(405.46f,44.09f,-44.51995f),ospreyprefab.transform.rotation);
                    PlayerHandler.isOsp = true;
                }
            }
        }
	}
}
