using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class capture : MonoBehaviour {
    //public MeshRenderer spr;
    public CreatureController creature;
    public Transform tr;
    public NavMeshAgent agent;
    public SphereCollider sph;
    public Animator anim;
    public flee fleee;
    public bool isStunned;
    public Vector3 pen1;
	// Use this for initialization
	void Start () {
        isStunned = false;
	}
	void Update()
    {
        if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Walking")))
        {
            if(agent.velocity != new Vector3 (0.0f,0.0f,0.0f))
            {
                anim.Play("Walking", -1,0);
            }
            
        }
        if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle1")))
        {
            if(isStunned == false)
            {
                if (agent.velocity == new Vector3(0.0f, 0.0f, 0.0f))
                {
                    anim.Play("Idle1", -1, 0);
                } 
            }
             
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Debug.Log("Creature Stunned");
            anim.Play("idletosleep", -1,0);
            creature.enabled = false;
            agent.enabled = false;
            fleee.enabled = false;
            sph.enabled = false;
            isStunned = true;
        }
        if(other.tag == "Player")
        {
            if(isStunned)
            {
                tr.position = pen1;
                creature.enabled = true;
                agent.enabled = true;
                PlayerHandler.bushmobs -= 1;
                PlayerHandler.capturedmobs += 1;
                //creature.wanderRadius = 1.5f;
                isStunned = false;
                PlayerHandler.batteries += 1;
                
            }
        }
        
    }
    
}
