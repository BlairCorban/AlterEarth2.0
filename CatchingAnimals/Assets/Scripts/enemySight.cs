using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemySight : MonoBehaviour {
	[SerializeField]float desReachTreshold;
	public NavMeshAgent Nav;
	public GameObject Player;
	public bool hunter = false;
	public int toHide = 0; 
	public int readyToHide = 4;
	//current possable Actions
	public enum state
	{
		Wonder,
		GetItem,
		Run,
		Hide,
		look
	}
	public state currentState;
	//variables for Investigate Spot
	Vector3 AimSpot;
	float Timer = 0;
	float WaitTimer = 10;

	public float HeightM;
	public float SightDis = 100;
	// Use this for initialization
	void Start () {
		HeightM = 0.64f;
		currentState = enemySight.state.Wonder;

		settingTarget ();
		//set wonder point
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Debug.DrawRay (transform.position + Vector3.up * HeightM, transform.forward * SightDis, Color.red);
		Debug.DrawRay (transform.position + Vector3.up * HeightM, (transform.forward + transform.right).normalized* SightDis, Color.black);
		Debug.DrawRay (transform.position + Vector3.up * HeightM, (transform.forward - transform.right).normalized * SightDis, Color.blue);
		if (Physics.Raycast (transform.position + Vector3.up * HeightM, transform.forward , out hit, SightDis)) {
			if (hit.collider.gameObject.tag == "Player") {
				Debug.Log ("Hit red");
				playerClose (hit);

			}
			if ((hit.collider.gameObject.tag == "Item")&&(hunter == false)) {
				Debug.Log ("Hit red");
				ItemClose (hit);

			}


		}
		if (Physics.Raycast (transform.position + Vector3.up * HeightM, (transform.forward + transform.right).normalized, out hit, SightDis)) {
			if (hit.collider.gameObject.tag == "Player") {
				Debug.Log ("Hit black");
				playerClose (hit);

			}
			if ((hit.collider.gameObject.tag == "Item")&&(hunter == false)) {
				Debug.Log ("Hit black");
				ItemClose (hit);

			}

		}
		if (Physics.Raycast (transform.position + Vector3.up * HeightM, (transform.forward - transform.right).normalized, out hit, SightDis)) {
			if (hit.collider.gameObject.tag == "Player") {
				Debug.Log ("Hit blue");
				playerClose (hit);

			}
			if ((hit.collider.gameObject.tag == "Item")&&(hunter == false)) {
				Debug.Log ("Hit blue");
				ItemClose (hit);

			}

		}
		float toTagret;
		switch (currentState) {
		case state.Wonder:
			// toTagret = Vector3.Distance (transform.position, AimSpot);
			//if (toTagret<desReachTreshold) {
			toTagret = Nav.remainingDistance;
			if((toTagret!= Mathf.Infinity)&&(Nav.remainingDistance >= 1)){
				settingTarget ();
			}
			break;
		case state.Hide:
			break;
		case state.look:
			break;
		case state.Run:
			if (toHide <= readyToHide) {
				if (Random.Range(1,3) == 1) {
					currentState = enemySight.state.Hide;	
				}

			}
			toTagret = Nav.remainingDistance;
			if((toTagret!= Mathf.Infinity)&&(Nav.remainingDistance >= 1)){
				settingTarget ();
			}
			toHide++;
			break;
		case state.GetItem:
			break;
		default:
			break;
		}
	}

	void playerClose(RaycastHit hit){
		hunter = true;
		//AimSpot.x = -AimSpot.x;
		//AimSpot.z = -AimSpot.z;
		//transform.LookAt(-AimSpot);
		currentState = enemySight.state.Run;

		float Dis = Random.Range (13, 20);
		float angle = Random.Range (-4/5, 4/5);
		AimSpot = transform.position + ((-transform.forward + (transform.right * angle)).normalized) * Dis;
		Nav.SetDestination(AimSpot);
		Nav.speed = 5f;
		Nav.acceleration = 10f;
	}
	void playerFar(RaycastHit hit){
		AimSpot = hit.collider.gameObject.transform.position;
		transform.LookAt(AimSpot);
		//show question mark
		currentState = enemySight.state.look;
	}
	void ItemClose(RaycastHit hit){
		AimSpot = hit.collider.gameObject.transform.position;
		transform.LookAt(AimSpot);
		//show question mark
		currentState = enemySight.state.GetItem;
	}

	void ItemFar(RaycastHit hit){
		AimSpot = hit.collider.gameObject.transform.position;
		transform.LookAt(AimSpot);
		//show question mark
		currentState = enemySight.state.look;
	}
	void settingTarget (){
		float Dis = Random.Range (6, 15);
		float angle;

		if (hunter == false) {
			 angle = Random.Range (-4/5, 4/5);
			Nav.speed = 2.5f;
			Nav.acceleration = 5f;
		} else {
			 angle = Random.Range (-1.5f, 1.5f);
			Nav.speed = 5f;
			Nav.acceleration = 10f;
		}

		AimSpot = transform.position + ((transform.forward + (transform.right * angle)).normalized) * Dis;
		Nav.SetDestination(AimSpot);
	}
}
