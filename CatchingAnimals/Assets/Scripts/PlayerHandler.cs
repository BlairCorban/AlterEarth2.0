using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    public static PlayerHandler m_sControl;
    public static int bushmobs;
    public static int capturedmobs;
    public static bool isOsp;
    public static int batteries;
    public static bool canfire;
    public static bool isospcaptured;
    public static int woodInventory;
    public GameObject gun1;
    public GameObject gun2;
    public static bool isgun1;
    public static int AmmoInt;
    public Text idol;
    public Text bush;
    public Text osprey;
    public Text ammotxt;
    public Text batteriestxt;
    public int speedMultiplier;
    public enum currentWep {TASER, NETGUN };
    public static currentWep m_playerWep;
    // Use this for initialization
    void Start()
    {
        bushmobs = 0;
        capturedmobs = 0;
        isOsp = false;
        batteries = 1;
        canfire = true;
        AmmoInt = 6;
        isgun1 = false;
        isospcaptured = false;
        woodInventory = 0;

        //m_playerWep = currentWep.NETGUN;
        gun1.SetActive(false);
        gun2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        ammotxt.text = AmmoInt.ToString();
        batteriestxt.text = batteries.ToString();






        if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (isgun1)
            {
                case true:
                    {
                        gun1.SetActive(false);
                        gun2.SetActive(true);
                        isgun1 = false;
                        //m_playerWep = currentWep.TASER;
                        print("WEAPON SET TO NETFUN");
                        break;
                    }
                case false:
                    {
                        gun1.SetActive(true);
                        gun2.SetActive(false);
                        isgun1 = true;
                        print("WEAPON SET TO TASER");
                        // m_playerWep = currentWep.NETGUN;
                        break;
                    }
            }
        }
    }
}
