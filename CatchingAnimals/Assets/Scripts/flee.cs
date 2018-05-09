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
        despawner = new Vector3(5.857544f, 41.48565f, 77.5f);
    }
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("flee");
            creature.enabled = false;
            agent.speed = 20;
            agent.SetDestination(despawner);
            Debug.Log(despawner);
        }
    }
}
