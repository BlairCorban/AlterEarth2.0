using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class flee : MonoBehaviour {
    public NavMeshAgent agent;
    public CreatureController creature;
    public Vector3 despawner;
	// Use this for initialization
    void Start()
    {
        
    }
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("flee");
            Debug.Log(despawner);
            creature.enabled = false;
            agent.speed = 15;
            agent.SetDestination(despawner);
        }
    }
}
