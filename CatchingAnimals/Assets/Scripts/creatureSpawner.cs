using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureSpawner : MonoBehaviour {
    public GameObject prefab;
    public Transform tr;
    public int amountCaptured;
    public Transform Navmesh;
	// Use this for initialization
	void Start () {
        amountCaptured = 0;
        InvokeRepeating("SpawnObj", 0f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnObj()
    {
        if(PlayerHandler.bushmobs  <= 14)
        {
            if(PlayerHandler.m_timeOfDay == PlayerHandler.TOD.DAY)
            {
                Instantiate(prefab, new Vector3(tr.position.x, Navmesh.position.y - 1.1f, tr.position.z), Quaternion.identity);
                PlayerHandler.bushmobs += 1;
            }
        }
    }
}
