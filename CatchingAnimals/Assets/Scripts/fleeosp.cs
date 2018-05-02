using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleeosp : MonoBehaviour {
    public bool spooked;
    public bool isstunned;
    public BoxCollider box;
    public Transform tr;
    public Animator anim;
    private bool isDespawning;
	// Use this for initialization
	void Start () {
        spooked = false;
        isstunned = false;
        isDespawning = false;
	}
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("spooked");
            spooked = true;
            box.enabled = false;
        }
        if(other.tag == "Respawn")
        {
            Debug.Log("respawn");
            spooked = false;
            tr.position = new Vector3(405.46f, 44.09f, -44.51995f);
            box.enabled = true;
        }
    }

	// Update is called once per frame
	void Update () {
		if(spooked)
        {
            if(!isstunned)
            {
                anim.Play("flap", -1, 0f);
                tr.Rotate(Vector3.right * 30 * Time.deltaTime);
                tr.Translate( Vector3.back * 100 * Time.deltaTime);
                if(!isDespawning)
                {
                    Invoke("DespawnOsprey", 6f);
                    isDespawning = true;
                }
                
            }
        }
	}
    void DespawnOsprey()
    {
        stats.isOsp = false;
        Destroy(gameObject);
    }
}
