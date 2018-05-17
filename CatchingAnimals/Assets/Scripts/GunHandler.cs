using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHandler : MonoBehaviour {

    enum compare {NETGUN, TASER };
    public Transform[] trself;
    public GameObject[] prefab;

    [SerializeField] private AudioClip m_acNetGunClip;
    [SerializeField] private AudioClip m_acTazerGunClip;
    private AudioSource m_asPlayAudio;
    // Use this for initialization
    void Start ()
    {
        m_asPlayAudio = GetComponent<AudioSource>();
    }

    private void PlayAudioForGuns()
    {
		
		// multi gun support would work better if we used enums and switched through the enum from say playerhandler
		// and then we just assigned the clip that way to the audiosource :D
        if (PlayerHandler.isgun1 == false)
        {
            m_asPlayAudio.clip = m_acNetGunClip;
        }
        else
        {
            m_asPlayAudio.clip = m_acTazerGunClip;
        }

        m_asPlayAudio.Play();
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
                        if (PlayerHandler.isgun1 == true)
                        {
                            Instantiate(prefab[0], trself[0].position, trself[0].rotation);
                            PlayerHandler.AmmoInt -= 1;
                            Debug.Log(PlayerHandler.AmmoInt);
                            Debug.Log("batteries: " + PlayerHandler.batteries);
                            PlayerHandler.canfire = false;
                            Invoke("firerate", .5f);
                            PlayAudioForGuns();
                          //  m_asPlayAudio.clip = m_acNetGunClip;
                          //  m_asPlayAudio.Play();
                        }
                    }
                }
                else
                {
                    Instantiate(prefab[1], trself[1].position, trself[1].rotation);
                    print("SPAWNNET");
                    PlayerHandler.canfire = false;
                    Invoke("firerate", .5f);
                    PlayAudioForGuns();
                    // m_asPlayAudio.clip = m_acNetGunClip;
                    // m_asPlayAudio.Play();
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
