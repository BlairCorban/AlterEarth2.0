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
    testpopup popup;
    public GameObject zzz;
    // Use this for initialization
    void Start()
    {
        popup = FindObjectOfType<testpopup>();
        isStunned = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
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
                popup.makePop("Osprey", "WOW, You Captured The Legendary Osprey!, Go Check It Out In It's Pen Back Home!");
                PlayerHandler.isOspCap = true;
                tr.position = new Vector3(-40.8f, 2.34f, 79.8f);
                isStunned = false;
                cap.enabled = false;
                zzz.SetActive(false);

            }
        }

    }

}
