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
    public GameObject pen1;
	// Use this for initialization
	void Start () {
        isStunned = false;
        pen1 = GameObject.Find("Fence");
	}
	void Update()
    {
        if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Walking")))
        {
            if(agent.velocity != Vector3.zero)
            {
                anim.Play("Walking", -1,0);
            }
            
        }
        if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle1")))
        {
            if(isStunned == false)
            {
                if (agent.velocity == Vector3.zero)
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
                tr.position = new Vector3(pen1.transform.position.x, 0, pen1.transform.position.z);
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
