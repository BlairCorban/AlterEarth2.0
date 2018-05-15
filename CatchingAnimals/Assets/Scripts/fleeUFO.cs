using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class fleeUFO : MonoBehaviour {
    public NavMeshAgent agent;
    public CreatureController creature;
    private bool isflee;
    private bool hasfleed;
    // Use this for initialization
    void Start()
    {
        isflee = false;
        hasfleed = false;
    }
    void Update()
    {
        if(isflee)
        {
            if (!hasfleed)
            {
                Invoke("deleteObj", 3f);
                hasfleed = true;
            }
            
            transform.parent.position += new Vector3(0, 20 * Time.deltaTime, 0);
        }
        /*if (PlayerHandler.m_timeOfDay == PlayerHandler.TOD.DAY)
        {
            creature.enabled = false;
            agent.enabled = false;
            isflee = true;
            
        }*/
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            creature.enabled = false;
            agent.enabled = false;
            isflee = true;
        }
    }
    void deleteObj()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
}
