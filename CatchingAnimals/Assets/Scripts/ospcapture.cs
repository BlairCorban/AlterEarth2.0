using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ospcapture : MonoBehaviour
{
    public ospcapture cap;
    public BoxCollider sph;
    public Transform tr;
    public Animator anim;
    public fleeosp fleee;
    public bool isStunned;
    public GameObject zzz;
    // Use this for initialization
    void Start()
    {
        isStunned = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("osprey Stunned");
            fleee.enabled = false;
            sph.enabled = false;
            isStunned = true;
			PlayerHandler.isospcaptured = true;
            zzz.SetActive(true);
        }
        if (other.tag == "Player")
        {
            if (isStunned)
            {
                Debug.Log("captured osp");
                tr.position = new Vector3(-40.39743f, 9.39f, 79.8418f);
                isStunned = false;
                cap.enabled = false;
                zzz.SetActive(false);

            }
        }

    }

}
