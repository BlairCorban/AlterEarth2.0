using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class captureUFO : MonoBehaviour {

    public CreatureController creature;
    public NavMeshAgent agent;
    public SphereCollider sph;
    public fleeUFO fleee;
    public bool isStunned;
    public GameObject pen1;
    public Rigidbody rb;
	// Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("Creature Stunned");
            creature.enabled = false;
            rb.useGravity = true;
            agent.enabled = false;
            fleee.enabled = false;
            sph.enabled = false;
            isStunned = true;
        }
    }
}
