using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    public static PlayerHandler m_sControl;
    public static int bushmobs;
    public static int UFOmobs;
    public static int capturedmobs;
    public static bool isOsp;
    public static int batteries;
    public static bool m_bPlayerMounted;
    public static bool canfire;
    public static bool isospcaptured;
    public static bool m_bPlayerCanMount;
    public static int woodInventory;
    public static int electronicsInventory;
    public static int fruitInventory;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject Sun;
    public GameObject Ceph; // simple bug fix
    public static bool isgun1;
    public static int AmmoInt;
    public Text idol;
    public Text bush;
    public Text osprey;
    public Text ammotxt;
    public Text batteriestxt;
    public Text m_tPopup;
    public int speedMultiplier;
    public enum TOD { DAY, NIGHT };
    public enum currentWep { TASER, NETGUN };
    public static currentWep m_playerWep;
    public static TOD m_timeOfDay;
    public static List<string> m_popupsToDisplay = new List<string>();
    public static Text[] m_sGlobalSimplePopup;

    public Camera m_FPScam;
    public Camera m_mountedCam;
    private Ray raycast;
    private static bool m_bClassSentPopup;

    // Use this for initialization
    void Start()
    {
        bushmobs = 0;
        UFOmobs = 0;
        capturedmobs = 0;
        isOsp = true;
        batteries = 1;
        canfire = true;
        AmmoInt = 6;
        isgun1 = false;
        isospcaptured = false;
        m_bPlayerMounted = false;
        m_bPlayerCanMount = false;
        m_bClassSentPopup = false;
        woodInventory = 0;
        electronicsInventory = 0;
        fruitInventory = 0;
        m_timeOfDay = TOD.DAY;
        m_popupsToDisplay.Add("");
        for (int i = 0; i < 10; i++)
        {
            m_sGlobalSimplePopup[i].text = "w";
        }
        //m_playerWep = currentWep.NETGUN;
        gun1.SetActive(false);
        gun2.SetActive(true);
       // m_FPScam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //m_mountedCam = GameObject.FindGameObjectWithTag("cephcamera").GetComponent<Camera>();
        m_FPScam.enabled = true;
        m_mountedCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        bush.text = woodInventory.ToString();
        idol.text = electronicsInventory.ToString();
        ammotxt.text = AmmoInt.ToString();
        batteriestxt.text = batteries.ToString();

        if (Sun.transform.position.y < 0)
        {
            m_timeOfDay = TOD.NIGHT;
        }
        else if (Sun.transform.position.y > 0)
        {
            m_timeOfDay = TOD.DAY;
        }
        if (m_bClassSentPopup && m_tPopup.text != "")
        {
            DisplayPopup(m_tPopup.text, 4.0f);
        }
        /*if (m_sGlobalSimplePopup[0].text != "")
        {
            DisplayPopup(m_sGlobalSimplePopup[0].text, 4.0f);
            m_sGlobalSimplePopup[0].text = "";
        }*/


        if (Input.GetKeyDown(KeyCode.Q))
        {
            HandlePlayerGun(false);
        }
        // Could put this in collect item but it's not really that lol.
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (m_bPlayerMounted == true)
            {
                PlayerCanMount();
            }
            else
            {
                int x = Screen.width / 2;
                int y = Screen.height / 2;
                RaycastHit hit;

                Ray ray = m_FPScam.ScreenPointToRay(new Vector3(x, y));

                Debug.DrawRay(ray.origin, ray.direction * 1000, new Color(1f, 0.922f, 0.016f, 1f));

                if (Physics.Raycast(ray, out hit, 5))
                {
                    if (hit.transform.tag == "ceph")
                    {
                        if (m_bPlayerCanMount)
                        {
                            PlayerCanMount();
                        }
                        else
                        {
                            if (PlayerHandler.fruitInventory >= 1)
                            {
                                DisplayPopup("Press 'e' to use one of your fruit's on the Ceph and tame it!", 4.0f);
                            }
                            else
                            {
                                DisplayPopup("Find a fruit to tame the Ceph!", 4.0f);
                            }
                        }
                    }
                }
            }
            //print("F PRESSED");

        }
    }

    private void HandlePlayerGun(bool _bTurnGunsOff)
    {
        if (_bTurnGunsOff == false)
        {
            switch (isgun1)
            {
                case true:
                    {
                        gun1.SetActive(false);
                        gun2.SetActive(true);
                        isgun1 = false;
                        DisplayPopup("Player Switched to the Net Gun", 2.0f);
                        break;
                    }
                case false:
                    {
                        gun1.SetActive(true);
                        gun2.SetActive(false);
                        isgun1 = true;
                        DisplayPopup("Player Switched to the Paralysis Gun", 2.0f);
                        break;
                    }
            }
        }
        else
        {
            switch (isgun1)
            {
                case true:
                    {
                        gun1.SetActive(true);
                        gun2.SetActive(false);
                        isgun1 = true;
                        //m_playerWep = currentWep.TASER;
                        break;
                    }
                case false:
                    {
                        gun1.SetActive(false);
                        gun2.SetActive(true);
                        isgun1 = false;
                        // m_playerWep = currentWep.NETGUN;
                        break;
                    }
            }
        }
    }

    private void RefreshText()
    {
        m_tPopup.text = "";
    }

    public void DisplayPopup(string _textToDisplay, float _displayTime) // displayTime is useless if this gets called again - it'l be overwritten
    {
        m_tPopup.text = _textToDisplay;
        Invoke("RefreshText", _displayTime);
    }

    

    public static void SendSimplePopup(string _textToDisplay)
    {
        /*if (m_bClassSentPopup)
        {
            m_bClassSentPopup = false;
        }
        m_tPopup.text = _textToDisplay;
        */
       // m_popupsToDisplay.Add(_textToDisplay);
        /*for (int i = 0; i < 10; i++)
        {
            if (m_sGlobalSimplePopup[i].text == "")
            {
                m_sGlobalSimplePopup[i].text = _textToDisplay;
                break;
            }
        }*/
        // m_popupsToDisplay[0] = _textToDisplay;
        //DisplayPopup(_textToDisplay, _displayTime);
    }

    private void PlayerCanMount()
    {
        if (m_bPlayerMounted == false)
        {
            this.transform.position = Ceph.transform.position;


            // Deactivate guns
            gun1.SetActive(false);
            gun2.SetActive(false);

            m_bPlayerMounted = true;
            UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.m_bPlayerIsMounted = true;
            m_FPScam.enabled = false;
            m_mountedCam.enabled = true;
            // m_tPopup.text = "Player Mounted Ceph";
            DisplayPopup("Player Mounted Ceph", 2.0f);
        }
        else // on dismount
        {
            this.transform.position = Ceph.transform.position;
            m_bPlayerMounted = false;
            UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.m_bPlayerIsMounted = false;
            m_FPScam.enabled = true;
            m_mountedCam.enabled = false;

            // enable player's gun
            HandlePlayerGun(true);
            DisplayPopup("Player Dismounted Ceph", 2.0f);
        }
    }
}
