using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHandler : MonoBehaviour {

    enum compare {NETGUN, TASER };
    public Transform[] trself;
    public GameObject prefab;
    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (PlayerHandler.canfire)
            {
                if (PlayerHandler.isgun1 == true)
                {
                    if (PlayerHandler.AmmoInt > 0)
                    {
                        // if (PlayerHandler.m_playerWep == 0)
                        if (PlayerHandler.isgun1 == true)
                        {
                            Instantiate(prefab, trself[0].position, trself[0].rotation);
                            PlayerHandler.AmmoInt -= 1;
                            Debug.Log(PlayerHandler.AmmoInt);
                            Debug.Log("batteries: " + PlayerHandler.batteries);
                            PlayerHandler.canfire = false;
                            Invoke("firerate", .5f);
                        }
                    }
                }
                else
                {
                    Instantiate(prefab, trself[1].position, trself[1].rotation);
                    print("SPAWNNET");
                    PlayerHandler.canfire = false;
                    Invoke("firerate", .5f);
                }
               
            }

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (PlayerHandler.m_playerWep == 0)
            {
                if (PlayerHandler.batteries > 0)
                {
                    PlayerHandler.AmmoInt = 6;
                    Debug.Log(PlayerHandler.AmmoInt);
                    PlayerHandler.batteries -= 1;
                }
            }

        }

    }

    void firerate()
    {
        PlayerHandler.canfire = true;
    }
}
