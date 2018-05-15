using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class flee : MonoBehaviour {
    public NavMeshAgent agent;
    public CreatureController creature;
    private GameObject despawner;
	// Use this for initialization
    void Start()
    {
        despawner = GameObject.Find("despawnbush");
    }
    void Update()
    {
        if(PlayerHandler.m_timeOfDay == PlayerHandler.TOD.NIGHT)
        {
            creature.enabled = false;
            agent.speed = 20;
            agent.SetDestination(despawner.transform.position);
        }
    }
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            creature.enabled = false;
            agent.speed = 20;
            agent.SetDestination(despawner.transform.position);
        }
    }
}
