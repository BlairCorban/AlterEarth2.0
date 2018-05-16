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
    public static bool canfire;
    public static bool isospcaptured;
    public static int woodInventory;
    public static int electronicsInventory;
    public static int fruitInventory;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject Sun;
    public static bool isgun1;
    public static int AmmoInt;
    public Text idol;
    public Text bush;
    public Text osprey;
    public Text ammotxt;
    public Text batteriestxt;
    public int speedMultiplier;
    public enum TOD {DAY, NIGHT};
    public enum currentWep {TASER, NETGUN };
    public static currentWep m_playerWep;
    public static TOD m_timeOfDay;
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
        woodInventory = 0;
        electronicsInventory = 0;
        fruitInventory = 0;
        m_timeOfDay = TOD.DAY;
        //m_playerWep = currentWep.NETGUN;
        gun1.SetActive(false);
        gun2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        bush.text = woodInventory.ToString();
        idol.text = electronicsInventory.ToString();
        ammotxt.text = AmmoInt.ToString();
        batteriestxt.text = batteries.ToString();

        if(Sun.transform.position.y < 0)
        {
            m_timeOfDay = TOD.NIGHT;
        }
        else if (Sun.transform.position.y > 0)
        {
            m_timeOfDay = TOD.DAY;
        }




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
                        break;
                    }
                case false:
                    {
                        gun1.SetActive(true);
                        gun2.SetActive(false);
                        isgun1 = true;
                        // m_playerWep = currentWep.NETGUN;
                        break;
                    }
            }
        }
    }
}
