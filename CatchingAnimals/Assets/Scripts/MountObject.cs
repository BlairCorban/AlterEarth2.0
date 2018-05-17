using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountObject : MonoBehaviour {
    Vector3 m_Direction;
    int m_Movement;
    //public MouseLook mouseLook = new MouseLook();
    public Camera cam;
    // Use this for initialization
    void Start ()
    {
        m_Direction = new Vector3(0, 0, 0);
        m_Movement = 30;
        cam = GameObject.FindGameObjectWithTag("cephcamera").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (PlayerHandler.m_bPlayerMounted == true)
        {
            while (Input.GetKey(KeyCode.W))
            {
                // positive vert
                this.transform.Translate(Vector3.forward * m_Movement * UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime);
                break;
            }
            
            while (Input.GetKey(KeyCode.S))
            {
                // neg vert
                this.transform.Translate(Vector3.back * (m_Movement *-1) * UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime);
                break;
            }

            while (Input.GetKey(KeyCode.A))
            {
                // negative horiz (left)
                this.transform.Translate(Vector3.left * (m_Movement * -1) * UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime);
                break;
            }

            while (Input.GetKey(KeyCode.D))
            {
                // positive horiz (right)
                this.transform.Translate(Vector3.right * m_Movement * UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime);
                break;
            }
        }
	}
}
