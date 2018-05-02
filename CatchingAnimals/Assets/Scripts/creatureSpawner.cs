using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureSpawner : MonoBehaviour {
    public GameObject prefab;
    public Transform tr;
    public int amountCaptured;
	// Use this for initialization
	void Start () {
        amountCaptured = 0;
        InvokeRepeating("SpawnObj", 0f, 30f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnObj()
    {
        if(stats.bushmobs  <= 14)
        {
            Instantiate(prefab, new Vector3(tr.position.x, 41.481F, tr.position.z), Quaternion.identity);
            stats.bushmobs += 1;
        }
        
    }
}
