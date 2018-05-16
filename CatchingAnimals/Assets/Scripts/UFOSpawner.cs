using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnUFO", 0, 5);
	}
	
    void SpawnUFO()
    {
        if(PlayerHandler.m_timeOfDay == PlayerHandler.TOD.NIGHT)
        {
            if (PlayerHandler.UFOmobs <= 15)
            {
                if (!GetComponent<MeshRenderer>().isVisible)
                {
                    Instantiate(prefab, new Vector3(transform.position.x + 10, 0 , transform.position.z), Quaternion.identity);
                    PlayerHandler.UFOmobs += 1;
                }
            }
        }
        
    }
}
